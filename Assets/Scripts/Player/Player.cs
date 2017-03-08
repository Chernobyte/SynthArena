﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour 
{
    public int maxcurrentJumpCount = 2;
    public float jumpStrength = 500.0f;
    public float gravityMultiplier = 2.0f;

    Overlord overlord;
    Rigidbody2D _rigidBody;
    BoxCollider2D _collider;
    int playerNumber;
    float topSpeed = 10.0f;
    float currentSpeed = 0.0f;
    float acceleration = 1.0f;
    InputController gamepad;
    private Vector2 controllerState;
    private Vector2 controllerStateR; //Right stick state
    private bool canJump = true;
    private bool onGround = false;
    private bool fastFalling = false;
    int currentJumpCount = 0;
    

    // Use this for initialization
    void Start() 
	{
		_rigidBody = gameObject.GetComponent<Rigidbody2D>();
        _collider = gameObject.GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update() 
	{
        HandleInput();
    }

    public void init(int playerNumber, Overlord overlord)
    {
        this.overlord = overlord;
        this.playerNumber = playerNumber;

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

        var jumpState = gamepad.L1();

        // Left Stick Input
        if (controllerState.x > 0.2 || controllerState.x < -0.2)
        {
            if (currentSpeed < topSpeed)
            {
                    currentSpeed += acceleration;
                if (currentSpeed > topSpeed) currentSpeed = topSpeed;
            }
        }
        // No Left Stick Input
        else
        {
            if (currentSpeed > 0)
            {
                currentSpeed -= acceleration;
                if (currentSpeed < 0) currentSpeed = 0;
            }
        }

        // Gravity
        if (fastFalling)
        {
            
        }
        else
        {
            _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, _rigidBody.velocity.y + Physics.gravity.y * gravityMultiplier * Time.deltaTime);
        }

        _rigidBody.velocity = new Vector2(currentSpeed * controllerState.x, _rigidBody.velocity.y);


        if (canJump && jumpState && currentJumpCount < maxcurrentJumpCount)
        {
            Jump();
        }
    }

    private void Jump()
    {
        currentJumpCount++;

        var actualJumpStrength = jumpStrength;
        
        _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, 0.0f); // ensures jump height is same every time
        _rigidBody.AddForce(Vector2.up * actualJumpStrength);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Platform")) return;

        {
            onGround = true;
            canJump = true;
            currentJumpCount = 0;
            fastFalling = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
