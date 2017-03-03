using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour 
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
		Move();

		//since we check for collision with the ground, the first jump will not increment the jump counter
		//PROBLEM: if the player jumps off the ledge and sticks to the side of the stage, he can jump
		//infinitely since the jump counter is reset each frame. How do we fix this?
		if (Input.GetButtonDown("Jump") && jump < 1) 
		{
			jump++;

			//this way, even if the player is falling, he'll have the same jump height every time
			playerRB.velocity = new Vector2(playerRB.velocity.x,0.0f);
			playerRB.AddForce(new Vector2(0.0f, jmpStr));
		}

		//reset jump count if player touches the ground
		if (playerBC.IsTouching(groundObj.GetComponent<BoxCollider2D>())) jump = 0;
	}

	//handles horizontal movement
	private void Move()
	{
		//wasd (and joystick?)
		float moveHorizontal 	= Input.GetAxis("Horizontal");

		if (moveHorizontal != 0.0f) 
			playerRB.velocity = new Vector2 (moveHorizontal * maxSpd * damp, playerRB.velocity.y);
	}
}
