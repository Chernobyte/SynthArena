using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchTest : MonoBehaviour 
{
	public Rigidbody2D rb;
	public float xForce;//temporary. different moves will have different magnitudes of force
	public float yForce;

	public float d; 			//base damage of move
	public float b; 			//base knockback of move
	public float s; 			//knockback scaling/growth
	public Vector2 ld; 			//launch direction relative to player

	public float w; 			//weight of character
	public float f; 			//max fall speed of character
	public bool stunned; 		//whether or not a character 

	private Vector2 negForce;
	public float NEG_FORCE_SCALE = 1.2f;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		stunned = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Debug.Log ("force applied");
			rb.AddForce (new Vector2 (xForce, yForce));
			//rb.AddForce(transform.up *10);

		}
	
		//this adds an opposing force to slow down the character. may need fine tuning
		if (stunned) 
		{
			if (rb.velocity.magnitude != 0f) 
			{
				//mult negative force by scaling factor 
				negForce = NEG_FORCE_SCALE * -rb.velocity;
				rb.AddRelativeForce (negForce);
			}
		}
	}
}
