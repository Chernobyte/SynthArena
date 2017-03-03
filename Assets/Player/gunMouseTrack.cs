using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunMouseTrack : MonoBehaviour {

	public Transform target;
	public float fRadius = 3.0f;
	private Transform pivot;
	// Use this for initialization
	void Start () {
		pivot = new GameObject ().transform;
		transform.parent = pivot;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v3Pos = Camera.main.WorldToScreenPoint (target.position);
		v3Pos = Input.mousePosition - v3Pos;
		float angle = Mathf.Atan2 (v3Pos.y, v3Pos.x) * Mathf.Rad2Deg;

		//pivot.position = target.position;
		//pivot.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		v3Pos = Quaternion.AngleAxis(angle, Vector3.forward) * (Vector3.right * fRadius);
		transform.position = target.position + v3Pos;
	}
}
