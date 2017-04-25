using System.Collections;
using XInputDotNetPure;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Skrush : Player
{

    public float jumpPreBuffer = 0.1f;
    public float jumpStrength = 20.0f;
    public float shortJumpStrength = 14.0f;
    public float maxJumpCount = 1;

    public float maxJetpackTimer = 5.0f;
    public float jetpackStrength = 0.3f;
    public float maxJetpackSpeed = 5.0f;

    public float fireRate = 1.0f;

    public GameObject spritesContainer;
    public Transform muzzle;
    public GameObject rocket;
    public GameObject mine;
    public float mineSpeed = 7.0f;
    public float maxMines = 3;

    public ParticleSystem leftJetpackParticles;
    public ParticleSystem rightJetpackParticles;

    public AudioClip jumpSound;
    public AudioClip jetpackStartSound;
    public AudioClip jetpackRepeatSound;
    public AudioClip rocketLaunchSound;
    public AudioClip painSound;

    private float aimAngle = 0.0f;
    private bool canFire = true;
    private bool lookingRight = true;

    private float currentJetpackTimer;
    private int currentJumpCount = 0;
    private float jumpPressedTime;
    private float jumpReleasedTime;
    private bool jumpBufferState = false;
    private bool jetpackEnabled;
    private float jetpackToggleTime;

    private float gravityForce;
    private bool applyDecelerationThisTick;
    private bool canJump = false;
    private bool fastFalling = false;

    private float currentStun;
    private Vector2 aimDirection;
    private float lastValidAimAngle = 0f;
    private bool onGroundPrevious;
    private List<Mine> deployedMines = new List<Mine>();

    private void Update()
    {
        HandleInput();

        HandleLookDirection();
        HandleAiming();

        UpdatePlayerUI();
    }

    private void FixedUpdate()
    {
        CalculateAbilityCooldowns();
        CalculateJetpackTimer();

        HandleJump();
        HandleGravity();
        ApplySpeedToRigidBody();
        CalculateStun();
        CheckDeath();
    }

    private void ApplySpeedToRigidBody()
    {
        if (onGround)
        {
            if (Mathf.Abs(currentSpeed) > Mathf.Abs(maxSpeed))
            {
                applyDecelerationThisTick = true;
            }
        }
        else
        {
            if (Mathf.Abs(currentSpeed) > Mathf.Abs(maxAirSpeed))
            {
                applyDecelerationThisTick = true;
            }
        }

        if (applyDecelerationThisTick)
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

        if (onGroundPrevious)
        {
            var displacement = new Vector3(_rigidBody.velocity.x * Time.deltaTime, _rigidBody.velocity.y * Time.deltaTime);

            if (-Mathf.Abs(displacement.x) < displacement.y && displacement.y < 0)
            {
                displacement.y = -Mathf.Abs(displacement.x) - 0.001f;
            }

            transform.position += new Vector3(0, displacement.y);
        }

        _rigidBody.velocity = new Vector2(currentSpeed, currentFallSpeed);

        if (onGround && currentFallSpeed < 0.5f)
            currentFallSpeed = 0;

        lowerBodyAnimator.SetFloat("fallSpeed", currentFallSpeed);
        if (currentFallSpeed < 0)
            lowerBodyAnimator.SetBool("isJumping", false);
        
        applyDecelerationThisTick = false;
        onGroundPrevious = onGround;
    }

    private void HandleGravity()
    {
        if (!calculateGravity)
        {
            _rigidBody.velocity = new Vector2(0, 0);
            return;
        }

        lowerBodyAnimator.SetInteger("jumpCount", currentJumpCount);

        if (jetpackEnabled)
        {
            if (currentFallSpeed < maxJetpackSpeed)
            {
                currentFallSpeed += jetpackStrength;
            }
        }
        else if (fastFalling)
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
    }

    private void setJetpack(bool value)
    {
        jetpackEnabled = value;
        lowerBodyAnimator.SetBool("isJetpacking", jetpackEnabled);

        if (jetpackEnabled)
        {
            leftJetpackParticles.Play();
            rightJetpackParticles.Play();
            audioSource.Play();
        }
        else
        {
            
            leftJetpackParticles.Stop();
            rightJetpackParticles.Stop();
            audioSource.Stop();
        }
    }

    private void CalculateJetpackTimer()
    {
        if (jetpackEnabled)
        {
            if (currentJetpackTimer <= 0)
            {
                currentJetpackTimer = 0;
                setJetpack(false);
            }
            else
            {
                currentJetpackTimer -= Time.deltaTime;
            }
        }
        else
        {
            if (currentJetpackTimer > maxJetpackTimer)
                currentJetpackTimer = maxJetpackTimer;

            if (currentJetpackTimer == maxJetpackTimer)
            {

            }
            else
            {
                currentJetpackTimer += Time.deltaTime;
            }
        }
    }

    private void CheckDeath()
    {
        if (isDead)
        {
            setJetpack(false);
        }
    }
    
    private void HandleInput()
    {
        gamePadState = GamePad.GetState(playerIndex);

        HandleLeftStickInput();
        HandleRightStickInput();
        HandleJumpInput();
        HandleAbility1Input();
        HandleAbility2Input();

        float fireState;
        ButtonState backState;

        if (acceptInput)
        {
            fireState = gamePadState.Triggers.Right;
            backState = gamePadState.Buttons.Back;
        }
        else
        {
            fireState = 0;
            backState = ButtonState.Released;
        }

        if (backState == ButtonState.Pressed && Time.time - forceRespawnInputBuffer > lastRespawnInputTime)
        {
            HandleDeath();
        }

        if (fireState > 0.2f && canFire)
        {
            FireWeapon();
            canFire = false;
            StartCoroutine(FireRoutine(fireRate));
        }

        previousGamePadState = gamePadState;
    }

    private void HandleRightStickInput()
    {
        if (acceptInput)
        {
            controllerStateR.x = gamePadState.ThumbSticks.Right.X;
            controllerStateR.y = gamePadState.ThumbSticks.Right.Y;
        }
        else
        {
            controllerStateR.x = 0;
            controllerStateR.y = 0;
        }

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
            spritesContainer.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            spritesContainer.transform.rotation = Quaternion.Euler(0, 180, 0);
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
        if (acceptInput)
        {
            controllerState.x = gamePadState.ThumbSticks.Left.X;
            controllerState.y = gamePadState.ThumbSticks.Left.Y;
        }
        else
        {
            controllerState.x = 0;
            controllerState.y = 0;
        }

        // Left Stick Right Tilt
        if (controllerState.x > 0.2)
        {
            if (onGround)
            {
                if (currentSpeed < maxSpeed)
                {
                    currentSpeed += acceleration;
                    if (currentSpeed > maxSpeed)
                        currentSpeed = maxSpeed;
                }
            }
            else
            {
                if (currentSpeed < maxAirSpeed)
                {
                    currentSpeed += acceleration;
                    if (currentSpeed > maxAirSpeed)
                        currentSpeed = maxAirSpeed;
                }
            }
            
            lowerBodyAnimator.SetBool("isRunning", true);
            lowerBodyAnimator.SetFloat("backpedalMultiplier", lookingRight ? 1.0f : -1.0f);
        }
        // Left Stick Left Tilt
        else if (controllerState.x < -0.2)
        {
            if (onGround)
            {
                if (currentSpeed > -maxSpeed)
                {
                    currentSpeed -= acceleration;
                    if (currentSpeed < -maxSpeed)
                        currentSpeed = -maxSpeed;
                }
            }
            else
            {
                if (currentSpeed > -maxAirSpeed)
                {
                    currentSpeed -= acceleration;
                    if (currentSpeed < -maxAirSpeed)
                        currentSpeed = -maxAirSpeed;
                }
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
        ButtonState jumpButtonState;
        ButtonState previousJumpButtonState;
        if (acceptInput)
        {
            jumpButtonState = gamePadState.Buttons.RightShoulder;
            previousJumpButtonState = previousGamePadState.Buttons.RightShoulder;
        }
        else
        {
            jumpButtonState = ButtonState.Released;
            previousJumpButtonState = ButtonState.Released;
        } 
        bool inputReceived, inputStopped;

        XInputDotNetHelpers.MapButtonStateToReceivedStopped(jumpButtonState, previousJumpButtonState, out inputReceived, out inputStopped);

        if (inputReceived)
        {
            jumpPressedTime = Time.time;

            if (canJump)
            {
                if (onGround)
                {
                    jumpBufferState = true;
                }
                else
                {
                    setJetpack(!jetpackEnabled);
                }
            }
        }

        if (inputStopped)
        {
            jumpReleasedTime = Time.time;
        }
    }

    private void HandleAbility1Input()
    {
        ButtonState ability1ButtonState;
        ButtonState previousAbility1ButtonState;
        if (acceptInput)
        {
            ability1ButtonState = gamePadState.Buttons.LeftShoulder;
            previousAbility1ButtonState = previousGamePadState.Buttons.LeftShoulder;
        }
        else
        {
            ability1ButtonState = ButtonState.Released;
            previousAbility1ButtonState = ButtonState.Released;
        }
        bool inputReceived, inputStopped;

        XInputDotNetHelpers.MapButtonStateToReceivedStopped(ability1ButtonState, previousAbility1ButtonState, out inputReceived, out inputStopped);

        if (inputReceived)
        {
            if (currentAbility1Cooldown == maxAbility1Cooldown)
            {
                ability1LastUseTime = Time.time;
                currentAbility1Cooldown = 0;
                Ability1();
            }
        }
    }

    private void HandleAbility2Input()
    {
        float ability2ButtonState;
        if (acceptInput)
        {
            ability2ButtonState = gamePadState.Triggers.Left;
        }
        else
        {
            ability2ButtonState = 0;
        }

        if (ability2ButtonState > 0)
        {
            if (currentAbility2Cooldown == maxAbility2Cooldown)
            {
                ability2LastUseTime = Time.time;
                currentAbility2Cooldown = 0;
                Ability2();
            }
        }
    }

    IEnumerator FireRoutine(float duration)
    {
        yield return new WaitForSeconds(duration);
        canFire = true;
    }

    private void FireWeapon()
    {
        var rocketInstance = Instantiate(rocket, muzzle.position, muzzle.rotation);

        rocketInstance.GetComponent<Rocket>().Initialize(aimDirection, this);

        audioSource.PlayOneShot(rocketLaunchSound);
    }

    private void Ability1()
    {
        var mineInstance = Instantiate(mine, muzzle.position, Quaternion.identity);
        var mineComponent = mineInstance.GetComponent<Mine>();
        mineComponent.Initialize(aimDirection, mineSpeed);

        deployedMines.Add(mineComponent);

        if (deployedMines.Count > maxMines)
        {
            var firstMine = deployedMines.First();
            deployedMines.Remove(firstMine);
            firstMine.Explode();
        }
    }

    private void Ability2()
    {
        foreach (var mineComponent in deployedMines)
        {
            mineComponent.Explode();
        }

        deployedMines.Clear();
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
        audioSource.PlayOneShot(jumpSound);
    }

    private void Jump()
    {
        PreJump();
        currentFallSpeed = jumpStrength;
        audioSource.PlayOneShot(jumpSound);
    }

    protected override void OnBottomTriggerEnter(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            if (!touchedPlatforms.Contains(collision.gameObject))
                touchedPlatforms.Add(collision.gameObject);

            CheckTouchedPlatforms();
        }
    }

    protected override void OnBottomTriggerExit(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            if (touchedPlatforms.Contains(collision.gameObject))
                touchedPlatforms.Remove(collision.gameObject);

            CheckTouchedPlatforms();
        }
    }

    private void CheckTouchedPlatforms()
    {
        if (touchedPlatforms.Count > 0 && currentFallSpeed <= 0)
        {
            onGround = true;
            canJump = true;
            currentJumpCount = 0;
            fastFalling = false;

            setJetpack(false);

            lowerBodyAnimator.SetInteger("jumpCount", currentJumpCount);
            lowerBodyAnimator.SetBool("isJumping", false);
        }
        else
        {
            onGround = false;
            currentJumpCount = 1;
            canJump = true;
        }
    }

    protected override void OnLeftTriggerStay(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            onWallLeft = true;
            fastFalling = false;

            lowerBodyAnimator.SetBool("wallSlide", true);
        }
    }

    protected override void OnLeftTriggerExit(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            onWallLeft = false;

            lowerBodyAnimator.SetBool("wallSlide", false);
        }
    }

    protected override void OnRightTriggerStay(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            onWallRight = true;
            fastFalling = false;

            lowerBodyAnimator.SetBool("wallSlide", true);
        }
    }

    protected override void OnRightTriggerExit(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            onWallRight = false;

            lowerBodyAnimator.SetBool("wallSlide", false);
        }
    }
}
