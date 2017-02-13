using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchTest : MonoBehaviour {
	public Rigidbody2D rb;
	public float xForce;
	public float yForce;

	public float d; 			//base damage of move
	public float b; 			//base knockback of move
	public float s; 			//knockback scaling/growth
	public Vector2 ld; 			//launch direction relative to player

	public float w; 			//weight of character
	public float f; 			//max fall speed of character
	public bool stunned; 		//whether or not a character 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Debug.Log ("force applied");
			rb.AddForce (new Vector2 (xForce, yForce));
			//rb.AddForce(transform.up *10);
		}
	}
}
