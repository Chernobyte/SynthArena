using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunMouseTrack : MonoBehaviour {

	public Transform target;
	public float fRadius = 3.0f;
	//private Transform pivot;

	// Use this for initialization
	void Start () {
		//pivot = new GameObject ().transform;
		//transform.parent = pivot;

		//without the above, the gun's size it skewed presumably based on the player's transform
		//is there a fix where the gun can still be a child of the player?
		//the size is fine if the gun is not a child of the player
	}
	
	// Update is called once per frame

	//make this work for controllers
	void Update () {
		Vector3 v3Pos = Camera.main.WorldToScreenPoint (target.position);
		v3Pos = Input.mousePosition - v3Pos;

		//for joysticks
		//float angle = Mathf.Atan2 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Mathf.Rad2Deg;

		float angle = Mathf.Atan2 (v3Pos.y, v3Pos.x) * Mathf.Rad2Deg;

		v3Pos = Quaternion.AngleAxis(angle, Vector3.forward) * (Vector3.right * fRadius);
		transform.position = target.position + v3Pos;

		//handle gun rotation
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

	}
}
