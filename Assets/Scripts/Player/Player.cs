using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	Rigidbody2D playerRB;
	BoxCollider2D playerBC;
	GameObject groundObj;
	public float maxSpd 	= 6.0f;
	public float jmpStr 	= 300.0f;
	//float fallStr   = -50.0f;
	public float damp		= 0.1f;
	public float jumpTime 	= 1.0f;
	int jump 				= 0;

    Overlord overlord;
    int playerNumber;
    float topSpeed = 10;
    float acceleration = 1;
    float currentSpeed = 0;
    InputController gamepad;
    private Vector2 controllerState;
    private Vector2 controllerStateR; //Right sticks state

    // Use this for initialization
    void Start () 
	{
		playerRB = gameObject.GetComponent<Rigidbody2D>();
		playerBC = gameObject.GetComponent<BoxCollider2D>();
		groundObj= GameObject.Find("floor");
	}
	
	// Update is called once per frame
	void Update () 
	{
        HandleInput();

		//since we check for collision with the ground, the first jump will not increment the jump counter
		//PROBLEM: if the player jumps off the ledge and sticks to the side of the stage, he can jump
		//infinitely since the jump counter is reset each frame. How do we fix this?

		//if (Input.GetButtonDown("Jump") && jump < 1) 
		//{
		//	jump++;

		//	//this way, even if the player is falling, he'll have the same jump height every time
		//	playerRB.velocity = new Vector2(playerRB.velocity.x,0.0f);
		//	playerRB.AddForce(new Vector2(0.0f, jmpStr));
		//}

		////reset jump count if player touches the ground
		//if (playerBC.IsTouching(groundObj.GetComponent<BoxCollider2D>())) jump = 0;
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

        //controllerState.x = Input.GetAxis("Joystick_0_PC_Move_X");

        Debug.Log(controllerState.x);

        controllerState.y = gamepad.Move_Y();
        controllerStateR.x = gamepad.Aim_X();
        controllerStateR.y = gamepad.Aim_Y();

        // Left Stick Input
        if (controllerState.x > 0.2 || controllerState.x < -0.2)
        {
            if (currentSpeed < topSpeed)
            {
                currentSpeed += acceleration;
                if (currentSpeed > topSpeed)
                {
                    currentSpeed = topSpeed;
                }
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

        playerRB.AddForce(new Vector2(currentSpeed * controllerState.x * Time.deltaTime, 0));

  //      //wasd (and joystick?)
  //      float moveHorizontal = Input.GetAxis("Horizontal");

            //if (moveHorizontal != 0.0f) 
            //	playerRB.velocity = new Vector2 (moveHorizontal * maxSpd * damp, playerRB.velocity.y);
    }
}
