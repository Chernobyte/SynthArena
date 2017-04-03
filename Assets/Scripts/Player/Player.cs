using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxcurrentJumpCount = 2;
    public float jumpPreBuffer = 0.1f;
    public float jumpStrength = 20.0f;
    public float shortJumpStrength = 14.0f;
    public float airJumpStrength = 18.5f;
    public float wallJumpStrength = 18.5f;
    public float wallJumpHorizontalMultiplier = 1.3f;
    public float shortWallJumpStrength = 14.0f;
    public float shortWallJumpHorizontalMultiplier = 0.8f;
    public float gravity = -1.0f;
    public float maxFallSpeed = -10.0f;
    public float acceleration = 0.7f;
    public float deceleration = 1.0f;
    public float airDeceleration = 0.5f;
    public float maxSpeed = 10.0f;
    public int maxHealth = 2000;
    public int currentHealth;
    public int numBouncesOnAbility;
    public float ability1CooldownTime = 8f;
    public float ability2CooldownTime = 10f;

    public GameObject topTriggerObject;
    public GameObject bottomTriggerObject;
    public GameObject leftTriggerObject;
    public GameObject rightTriggerObject;
    public Animator upperBodyAnimator;
    public Animator lowerBodyAnimator;

    //for aiming
    public GameObject sprites;
    public GameObject weapon;
    public GameObject arm;
    public Transform muzzle;
    
    // bullet
    public GameObject bullet;
    public float bulletSpeed = 5.0f;
    public float fireRate = 1.0f;
    public bool bouncing = false;

    private float ability1LastUseTime;
    private float currentAbility1Cooldown;
    private float ability2LastUseTime;
    private float currentAbility2Cooldown;

    private float aimAngle = 0.0f;
    private bool canFire = true;

    //ability stuff
    private Overlord overlord;
    private PlayerUI playerUI;
    private Rigidbody2D _rigidBody;
    private BoxCollider2D _collider;
    private AudioSource _audio;

    private int playerNumber;
    private float currentSpeed = 0.0f;
    private float currentFallSpeed = 0.0f;

    private InputController gamepad;
    private Vector2 controllerState;
    private Vector2 controllerStateR; //Right stick state
    private bool canJump = false;
    private bool onWallLeft = false;
    private bool onWallRight = false;
    private bool canWallJumpToLeft = false;
    private bool canWallJumpToRight = false;
    private bool onGround = false;
    private bool fastFalling = false;
    private int currentJumpCount = 0;
    private float gravityForce;
    private float jumpPressedTime;
    private float jumpReleasedTime;
    private bool jumpBufferState = false;
    private bool wallJumpBufferState = false;
    private bool applyDecelerationThisTick;
    private bool lookingRight = true;
    private float currentStun;
    private bool notStunned = true;
    private Vector2 aimDirection;
    private float lastValidAimAngle = 0f;

    private void Start() 
	{
		_rigidBody = gameObject.GetComponent<Rigidbody2D>();
        _collider = gameObject.GetComponent<BoxCollider2D>();
        _audio = gameObject.GetComponent<AudioSource>();

        InitializeTriggers();
        InitializeHurtboxes();

        currentHealth = maxHealth;

        currentAbility1Cooldown = ability1CooldownTime;
        currentAbility2Cooldown = ability2CooldownTime;
    }

    private void InitializeTriggers()
    {
        topTriggerObject.GetComponent<TriggerCallback>().Init(OnTopTriggerEnter, OnTopTriggerEnter);
        bottomTriggerObject.GetComponent<TriggerCallback>().Init(OnBottomTriggerEnter, OnBottomTriggerExit);
        leftTriggerObject.GetComponent<TriggerCallback>().Init(OnLeftTriggerEnter, OnLeftTriggerExit);
        rightTriggerObject.GetComponent<TriggerCallback>().Init(OnRightTriggerEnter, OnRightTriggerExit);
    }

    private void InitializeHurtboxes()
    {
        var hurtboxes = GetComponentsInChildren<HitboxCallback>();
        foreach (var hurtbox in hurtboxes)
        {
            hurtbox.Init(OnHitboxTriggerEnter, OnHitboxTriggerExit, this);
        }
    }

    private void Update()
	{
        HandleAbilityCooldowns();

        HandleInput();
        HandleLookDirection();
        HandleAiming();

        UpdateHealthBar();
        UpdateAbilitiesCD();
    }

    private void FixedUpdate()
    {
        HandleJump();
        HandleGravity();
        ApplySpeedToRigidBody();
        HandleHitStun();
    }

    public void Init(int playerNumber, Overlord overlord, PlayerUI playerUI)
    {
        this.overlord = overlord;
        this.playerNumber = playerNumber;
        this.playerUI = playerUI;

        switch (playerNumber)
        {
            case 1: gamepad = new InputController(ControllerNumber.ONE); break;
            case 2: gamepad = new InputController(ControllerNumber.TWO); break;
            case 3: gamepad = new InputController(ControllerNumber.THREE); break;
            case 4: gamepad = new InputController(ControllerNumber.FOUR); break;
        }
    }

    public void ApplyForce(Vector2 force, int weaponDamage , float timeStunned)
    {
        currentSpeed += force.x;
        currentFallSpeed += force.y;
        if(weaponDamage!=0)
        {
            currentHealth -= weaponDamage;
        }
        currentStun = Time.time + timeStunned;
    }

    private void ApplySpeedToRigidBody()
    {
        if (Mathf.Abs(currentSpeed) > Mathf.Abs(maxSpeed))
        {
            applyDecelerationThisTick = true;
        }

        if (applyDecelerationThisTick == true)
        {
            float actualDeceleration = deceleration;

            if (!onGround)
                actualDeceleration = airDeceleration;

            if (currentSpeed < 0)
            {
                if (-actualDeceleration < currentSpeed)
                {
                    currentSpeed = 0;
                }
                else
                {
                    currentSpeed += actualDeceleration;
                }
            }
            else if (currentSpeed > 0)
            {
                if (actualDeceleration > currentSpeed)
                {
                    currentSpeed = 0;
                }
                else
                {
                    currentSpeed -= actualDeceleration;
                }
            }
        }

        if (currentFallSpeed < 0)
        {
            lowerBodyAnimator.SetBool("isJumping", false);
        }

        lowerBodyAnimator.SetFloat("fallSpeed", currentFallSpeed);

        applyDecelerationThisTick = false;

        _rigidBody.velocity = new Vector2(currentSpeed, currentFallSpeed);
    }

    private void HandleGravity()
    {
        if (!onGround)
        {
            if (fastFalling)
            {
                currentFallSpeed = maxFallSpeed * 1.5f;
            }
            else
            {
                currentFallSpeed += gravity;

                if (onWallLeft || onWallRight)
                {
                    if (currentFallSpeed < maxFallSpeed / 1.5f)
                        currentFallSpeed = maxFallSpeed / 1.5f;
                }
                else
                {
                    if (currentFallSpeed < maxFallSpeed)
                        currentFallSpeed = maxFallSpeed;
                }
            }
        }
    }

    private void HandleJump()
    {
        var timeSinceJumpOrdered = Time.time - jumpPressedTime;
        var jumpButtonHeldLength = jumpReleasedTime - jumpPressedTime;

        if (onGround)
        {
            if (jumpBufferState && timeSinceJumpOrdered > jumpPreBuffer)
            {
                if (jumpButtonHeldLength < 0) // not yet released
                {
                    Jump();
                }
                else
                {
                    ShortJump();
                }

                jumpBufferState = false;
            }
        }
        else
        {
            if (wallJumpBufferState && timeSinceJumpOrdered > jumpPreBuffer)
            {
                WallJumpDirection direction;

                wallJumpBufferState = false;

                if (onWallLeft)
                {
                    direction = WallJumpDirection.Right;
                }
                else if (onWallRight)
                {
                    direction = WallJumpDirection.Left;
                }
                else
                {
                    return;
                }

                if (jumpButtonHeldLength < 0) // not yet released
                {
                    WallJump(direction);
                }
                else
                {
                    ShortWallJump(direction);
                }
            }
        }
    }

    private void HandleAbilityCooldowns()
    {
        if (currentAbility1Cooldown < ability1CooldownTime)
        {
            currentAbility1Cooldown = Time.time - ability1LastUseTime;
            if (currentAbility1Cooldown > ability1CooldownTime)
                currentAbility1Cooldown = ability1CooldownTime;
        }

        if (currentAbility2Cooldown < ability2CooldownTime)
        {
            currentAbility2Cooldown = Time.time - ability2LastUseTime;
            if (currentAbility2Cooldown > ability2CooldownTime)
                currentAbility2Cooldown = ability2CooldownTime;
        }
    }

    private void HandleInput()
    {
        //get controller state
        controllerState.x = gamepad.Move_X();
        controllerState.y = gamepad.Move_Y();
        controllerStateR.x = gamepad.Aim_X();
        controllerStateR.y = gamepad.Aim_Y();

        HandleLeftStickInput();
        HandleRightStickInput();
        HandleJumpInput();
        HandleAbility1Input();
        HandleAbility2Input();
        
		var fireState = gamepad.R2();
        

		if (fireState > 0.2f && canFire) 
		{
			FireWeapon();
			canFire = false;
			StartCoroutine(FireRoutine (fireRate));
		}
    }

    private void HandleRightStickInput()
    {
        // Right Stick Right Tilt
        if (controllerStateR.x > 0)
        {
            lookingRight = true;   
        }
        // Right Stick Left Tilt
        else if (controllerStateR.x < 0)
        {
            lookingRight = false;
        }
        // No Right Stick X Input
        else
        {

        }
    }

    private void HandleLookDirection()
    {
        if (onWallLeft)
        {
            lookingRight = true;
        }
        else if (onWallRight)
        {
            lookingRight = false;
        }

        if (lookingRight)
        {
            sprites.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            sprites.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private void HandleAiming()
    {
        if (lookingRight)
        {
            aimAngle = Mathf.Atan2(controllerStateR.y, controllerStateR.x) * Mathf.Rad2Deg;
        }
        else
        {
            aimAngle = Mathf.Atan2(controllerStateR.y, -controllerStateR.x) * Mathf.Rad2Deg;
        }

        aimDirection = new Vector2(muzzle.transform.right.x, muzzle.transform.right.y);

        if (controllerStateR.y == 0 && controllerStateR.x == 0)
        {
            aimAngle = lastValidAimAngle;
        }
        else
        {
            lastValidAimAngle = aimAngle;
        }

        var aimBlend = (aimAngle + 90.0f) / 180.0f;
        upperBodyAnimator.SetFloat("aimBlend", aimBlend);
    }

    private void HandleLeftStickInput()
    {
        // Left Stick Right Tilt
        if (controllerState.x > 0.2)
        {
            if (currentSpeed < maxSpeed)
            {
                currentSpeed += acceleration;
                if (currentSpeed > maxSpeed)
                    currentSpeed = maxSpeed;
            }
            lowerBodyAnimator.SetBool("isRunning", true);
            lowerBodyAnimator.SetFloat("backpedalMultiplier", lookingRight ? 1.0f : -1.0f);
        }
        // Left Stick Left Tilt
        else if (controllerState.x < -0.2)
        {
            if (currentSpeed > -maxSpeed)
            {
                currentSpeed -= acceleration;
                if (currentSpeed < -maxSpeed)
                    currentSpeed = -maxSpeed;
            }
            lowerBodyAnimator.SetBool("isRunning", true);
            lowerBodyAnimator.SetFloat("backpedalMultiplier", lookingRight ? -1.0f : 1.0f);
        }
        // No Left Stick X Input
        else
        {
            applyDecelerationThisTick = true;
            lowerBodyAnimator.SetBool("isRunning", false);
        }

        // Left Stick Y Input
        if (controllerState.y < -0.8)
        {
            if (!onGround && !onWallLeft && !onWallRight)
            {
                fastFalling = true;
            }
        }
    }

    private void HandleJumpInput()
    {
        var jumpInputReceived = gamepad.R1();
        var jumpInputStopped = gamepad.R1Up();

        if (jumpInputReceived)
        {
            jumpPressedTime = Time.time;

            if (canJump)
            {
                if (onWallLeft && !onGround && canWallJumpToRight)
                {
                    wallJumpBufferState = true;
                }
                else if (onWallRight && !onGround && canWallJumpToLeft)
                {
                    wallJumpBufferState = true;
                }
                else if (currentJumpCount < maxcurrentJumpCount)
                {
                    if (onGround)
                    {
                        jumpBufferState = true;
                    }
                    else
                    {
                        AirJump();
                    }
                }
            }
        }

        if (jumpInputStopped)
        {
            jumpReleasedTime = Time.time;
        }
    }

    private void HandleAbility1Input()
    {
        var ability1 = gamepad.L1();
        
        if (ability1)
        {
            if (currentAbility1Cooldown == ability1CooldownTime)
            {
                ability1LastUseTime = Time.time;
                currentAbility1Cooldown = 0;
                Ability1();
            }
        }
    }

    private void HandleAbility2Input()
    {
        var ability2 = gamepad.L2();

        if (ability2 != 0)
        {
            if (currentAbility2Cooldown == ability2CooldownTime)
            {
                ability2LastUseTime = Time.time;
                currentAbility2Cooldown = 0;
                Ability2();
            }
        }
    }

    

    private void HandleHitStun()
    {
        if (currentStun != 0)
        {
            if (Time.time > currentStun)
            {
                notStunned = true;
                currentStun = 0;
            }
            else
                notStunned = false;
        }
    }

    IEnumerator FireRoutine(float duration)
    {
        yield return new WaitForSeconds(duration);
        canFire = true;
    }

    private void FireWeapon()
    {
        var bulletInstance = Instantiate(bullet, muzzle.position, muzzle.rotation);

        var rb = bulletInstance.GetComponent<Rigidbody2D>();

        int numBounces = 0;

        if (bouncing)
        {
            numBounces = numBouncesOnAbility;
        }

        bulletInstance.GetComponent<Bullet>().Initialize(numBounces, aimDirection, this);
        
        _audio.Play();
    }

    private void Ability1()
    {
        gameObject.GetComponent<AbilityOne>().fire(weapon.transform);
    }

    private void Ability2()
    {
        gameObject.GetComponent<AbilityTwo>().fire(weapon.transform);
    }

    private void PreJump()
    {
        currentJumpCount++;
        lowerBodyAnimator.SetInteger("jumpCount", currentJumpCount);
        lowerBodyAnimator.SetBool("isJumping", true);
        fastFalling = false;
    }

    private void ShortJump()
    {
        PreJump();
        currentFallSpeed = shortJumpStrength;
    }

    private void Jump()
    {
        PreJump();
        currentFallSpeed = jumpStrength;
    }

    private void AirJump()
    {
        currentJumpCount++;
        fastFalling = false;
        canWallJumpToRight = true;
        canWallJumpToLeft = true;

        if (controllerState.x > 0.2 || controllerState.x < -0.2)
        {
            currentSpeed = maxSpeed * controllerState.x;
        }

        currentFallSpeed = airJumpStrength;

        lowerBodyAnimator.SetInteger("jumpCount", currentJumpCount);
        lowerBodyAnimator.SetBool("isJumping", true);
    }

    private enum WallJumpDirection { Left, Right };

    private void ShortWallJump(WallJumpDirection direction)
    {
        fastFalling = false;

        if (direction == WallJumpDirection.Right)
        {
            currentSpeed = maxSpeed * shortWallJumpHorizontalMultiplier;
            canWallJumpToRight = false;
            canWallJumpToLeft = true;
        }
        else if (direction == WallJumpDirection.Left)
        {
            currentSpeed = -maxSpeed * shortWallJumpHorizontalMultiplier;
            canWallJumpToLeft = false;
            canWallJumpToRight = true;
        }

        currentFallSpeed = shortWallJumpStrength;
    }

    private void WallJump(WallJumpDirection direction)
    {
        fastFalling = false;

        if (direction == WallJumpDirection.Right)
        {
            currentSpeed = maxSpeed * wallJumpHorizontalMultiplier;
            canWallJumpToRight = false;
            canWallJumpToLeft = true;
        }
        else if (direction == WallJumpDirection.Left)
        {
            currentSpeed = -maxSpeed * wallJumpHorizontalMultiplier;
            canWallJumpToLeft = false;
            canWallJumpToRight = true;
        }

        currentFallSpeed = wallJumpStrength;
    }

    public void OnTopTriggerEnter(Collider2D collision)
    {

    }

    public void OnTopTriggerExit(Collider2D collision)
    {

    }

    public void OnBottomTriggerEnter(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            onGround = true;
            canJump = true;
            canWallJumpToLeft = true;
            canWallJumpToRight = true;
            currentJumpCount = 0;
            currentFallSpeed = 0;
            fastFalling = false;
            
            lowerBodyAnimator.SetInteger("jumpCount", currentJumpCount);
            lowerBodyAnimator.SetBool("isJumping", false);
        }
    }

    public void OnBottomTriggerExit(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            onGround = false;
            currentJumpCount = 1;
            canJump = true;

            lowerBodyAnimator.SetInteger("jumpCount", currentJumpCount);
        }
    }

    public void OnLeftTriggerEnter(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            onWallLeft = true;
            fastFalling = false;

            lowerBodyAnimator.SetBool("wallSlide", true);
        }
    }

    public void OnLeftTriggerExit(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            onWallLeft = false;

            lowerBodyAnimator.SetBool("wallSlide", false);
        }
    }

    public void OnRightTriggerEnter(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            onWallRight = true;
            fastFalling = false;

            lowerBodyAnimator.SetBool("wallSlide", true);
        }
    }

    public void OnRightTriggerExit(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            onWallRight = false;

            lowerBodyAnimator.SetBool("wallSlide", false);
        }
    }

    public void OnHitboxTriggerEnter(Collider2D collision)
    {

    }

    public void OnHitboxTriggerExit(Collider2D collision)
    {

    }

    private void UpdateHealthBar()
    {
        playerUI.UpdateHealthBar(currentHealth, maxHealth);
    }

    private void UpdateAbilitiesCD()
    {
        playerUI.UpdateAbilitiesCD(currentAbility1Cooldown, ability1CooldownTime, currentAbility2Cooldown, ability2CooldownTime);
    }
}
