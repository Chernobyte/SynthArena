using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour 
{
    public int maxcurrentJumpCount = 2;
    public float jumpStrength = 500.0f;
    public float gravityMultiplier = 2.0f;
    public float maxFallSpeed = -10.0f;
    public int maxHealth = 2000;
    public int currentHealth;

    public GameObject topTriggerObject;
    public GameObject bottomTriggerObject;
    public GameObject leftTriggerObject;
    public GameObject rightTriggerObject;

    //for aiming
    public Transform gun;
	public float fRadius = 1.0f;
	public float bulletSpeed = 5.0f;
	public Vector3 gunPosOffset = new Vector3(0.0f, 0.0f, -0.1f); //use this to line up arm with character's shoulder
	//bullet
	public GameObject bullet;
	public float bulletSpawnOffset = 1.2f;
	public float fireRate = 1.0f;

    //grenade
    public GameObject grenade;

    Overlord overlord;
    HealthDisplay healthDisplay;
    Rigidbody2D _rigidBody;
    BoxCollider2D _collider;

    int playerNumber;
    float topSpeed = 10.0f;
    float currentSpeed = 0.0f;
    float acceleration = 1.0f;
    float deceleration = -0.2f;
    float currentFallSpeed = 0.0f;
    InputController gamepad;
    private Vector2 controllerState;
    private Vector2 controllerStateR; //Right stick state
    private bool canJump = true;
    private bool canWallJump = false;
    private bool onGround = true;
    private bool fastFalling = false;
    int currentJumpCount = 0;

	//for aiming
	float angle = 0.0f;
	Vector3 gunPos = new Vector3(1.0f, 0.0f, 0.0f);
	bool canFire = true;

    // Use this for initialization
    void Start() 
	{
		_rigidBody = gameObject.GetComponent<Rigidbody2D>();
        _collider = gameObject.GetComponent<BoxCollider2D>();

        InitializeTriggers();

        currentHealth = maxHealth;
		gunPos = new Vector3 (fRadius, 0.0f, 0.0f);
		gun.position = transform.position + gunPos + gunPosOffset;
	}

    private void InitializeTriggers()
    {
        topTriggerObject.GetComponent<TriggerCallback>().Init(OnTopTriggerEnter, OnTopTriggerEnter);
        bottomTriggerObject.GetComponent<TriggerCallback>().Init(OnBottomTriggerEnter, OnBottomTriggerExit);
        leftTriggerObject.GetComponent<TriggerCallback>().Init(OnLeftTriggerEnter, OnLeftTriggerExit);
        rightTriggerObject.GetComponent<TriggerCallback>().Init(OnRightTriggerEnter, OnRightTriggerExit);
    }

    // Update is called once per frame
    void Update() 
	{
        HandleInput();
        UpdateHealthBar();
    }

    public void init(int playerNumber, Overlord overlord, HealthDisplay healthDisplay)
    {
        this.overlord = overlord;
        this.playerNumber = playerNumber;
        this.healthDisplay = healthDisplay;

        switch (playerNumber)
        {
            case 1: gamepad = new InputController(ControllerNumber.ONE); break;
            case 2: gamepad = new InputController(ControllerNumber.TWO); break;
            case 3: gamepad = new InputController(ControllerNumber.THREE); break;
            case 4: gamepad = new InputController(ControllerNumber.FOUR); break;
        }
    }

    private void HandleInput()
    {
        //get controller state
        controllerState.x = gamepad.Move_X();
        controllerState.y = gamepad.Move_Y();
        controllerStateR.x = gamepad.Aim_X();
        controllerStateR.y = gamepad.Aim_Y();
        
        var jumpInputReceived = gamepad.R1();
		var fireState = gamepad.R2();
        var ability1 = gamepad.L1();
        var ability2 = gamepad.L2();

        // Left Stick X Input
        if (controllerState.x > 0.2 || controllerState.x < -0.2)
        {
            if (currentSpeed < topSpeed)
            {
                currentSpeed += acceleration;
                if (currentSpeed > topSpeed) currentSpeed = topSpeed;
            }
        }
        // No Left Stick X Input
        else
        {
            if (currentSpeed > 0)
            {
                currentSpeed += deceleration;
                if (currentSpeed < 0) currentSpeed = 0;
            }
        }

        // Left Stick Y Input
        if (controllerState.y < -0.8)
        {
            if (!onGround)
            {
                fastFalling = true;
            }
        }

        // Gravity
        if (fastFalling)
        {
            _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, maxFallSpeed * 2);
        }
        else
        {
            var gravityForce = +Physics.gravity.y * gravityMultiplier * 0.01f;
            var currentFallSpeed = _rigidBody.velocity.y + gravityForce;
            if (currentFallSpeed < maxFallSpeed) currentFallSpeed = maxFallSpeed;

            _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, currentFallSpeed);
        }

        _rigidBody.velocity = new Vector2(currentSpeed * controllerState.x, _rigidBody.velocity.y);


        if (canJump && jumpInputReceived)
        {
            if (canWallJump)
            {
                WallJump();
            }
            else if (currentJumpCount < maxcurrentJumpCount)
            {
                Jump();
            }
        }

		// handle aiming (right stick)
		if (controllerStateR.magnitude > 0.2f) 
		{
			angle = Mathf.Atan2 (controllerStateR.y, controllerStateR.x) * Mathf.Rad2Deg;
			gunPos = Quaternion.AngleAxis(angle, Vector3.forward) * (Vector3.right * fRadius);
			//gun.position = transform.position + gunPos + gunPosOffset;

			// handle gun rotation (why the fuck is it gettign skewed? the scale doesnt change?)
			//because the player's y value for their scale is 2, numbnutz. and this passes down to the child
			//How to fix this without changing the player's x,y scale values to 1?
			gun.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}
		gun.position = transform.position + gunPos + gunPosOffset;

		if (fireState > 0.2f && canFire) 
		{
			FireWeapon ();
			canFire = false;
			StartCoroutine (FireRoutine (fireRate));
		}

        if(ability1)
        {
            Ability1();
        }
        if(ability2>.2)
        {
            Ability2();
        }

    }

	IEnumerator FireRoutine(float duration)
	{
		yield return new WaitForSeconds (duration);
		canFire = true;
	}

	private void FireWeapon()
	{
		GameObject curBullet = Instantiate (bullet, 
											gun.transform.position + (gun.transform.right * bulletSpawnOffset), 
											gun.transform.rotation);
		Rigidbody2D rb = curBullet.GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2(gun.transform.right.x, gun.transform.right.y) * bulletSpeed;
	}

    private void Ability1()
    {
        GameObject curBullet = Instantiate(grenade,
                                            gun.transform.position + (gun.transform.right * bulletSpawnOffset),
                                            gun.transform.rotation);
        Rigidbody2D rb = curBullet.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(gun.transform.right.x, gun.transform.right.y) * bulletSpeed;
    }

    private void Ability2()
    {

    }

    private void Jump()
    {
        currentJumpCount++;
        fastFalling = false;

        var actualJumpStrength = jumpStrength;
        
        _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, 0.0f); // ensures jump height is same every time
        _rigidBody.AddForce(Vector2.up * actualJumpStrength);
    }

    private void WallJump()
    {
        var actualJumpStrength = jumpStrength;

        _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, 0.0f); // ensures jump height is same every time
        _rigidBody.AddForce(new Vector2(1.0f, 1.0f) * actualJumpStrength);

        Debug.Log("WALLJUMP");
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
            currentJumpCount = 0;
            fastFalling = false;
        }
    }

    public void OnBottomTriggerExit(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            onGround = false;
            currentJumpCount = 1;
            canJump = true;
        }
    }

    public void OnLeftTriggerEnter(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            canWallJump = true;
            fastFalling = false;
        }
    }

    public void OnLeftTriggerExit(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            canWallJump = false;
        }
    }

    public void OnRightTriggerEnter(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            canWallJump = true;
            fastFalling = false;
        }
    }

    public void OnRightTriggerExit(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            canWallJump = false;
        }
    }

    private void UpdateHealthBar()
    {
        healthDisplay.UpdateHealthDisplay(currentHealth, maxHealth);
    }
}
