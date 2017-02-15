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
	public float curPerc;
	public float w; 			//weight of character
	public float f; 			//max fall speed of character
	public bool stunned; 		//whether or not a character 

	public float DRAG_SCALE = 1f;

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
			float tmp = Knockback ();
			//rb.AddForce (new Vector2 (0f, tmp));
			Debug.Log (tmp);
			rb.AddForce (new Vector2 (xForce, yForce));


			stunned = true;
			Debug.Log ("stunned!");
			return;
		}
	
		//this adds drag to slow down the character's upward ascent. may need fine tuning
		if (stunned) 
		{
			if (rb.velocity.y > 0f) 
			{
				rb.drag = DRAG_SCALE;
			} else {
				Debug.Log ("not stunned");
				rb.drag = 0f;
				stunned = false;

			}
		}
	}

	private float Knockback()
	{
		return s * (((14 * (curPerc + d) * (d + 2)) / (w + 100)) + 18) + b;
	}
}
