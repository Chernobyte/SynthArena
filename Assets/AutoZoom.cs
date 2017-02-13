using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoZoom : MonoBehaviour {
	//public List<GameObject> objects;

	public Transform player1;
	public Transform player2;

	public float DISTANCE_MARGIN = 0.0f;

	private Vector3 middlePoint;
	private float distanceFromMiddlePoint;
	private float distanceBetweenPlayers;
	private float cameraDistance;
	private float aspectRatio;
	private float fov;
	private float tanFov;
	private Vector3 cross;



	void Start() {
		aspectRatio = Screen.width / Screen.height;
		//objects = new List<GameObject> ();
		tanFov = Mathf.Tan(Mathf.Deg2Rad * Camera.main.fieldOfView / 2.0f);
	}

	/*private void getObjs()
	{
		//get all player objects 
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");

		//push player objects to object list
		objects
	}*/

	void Update () {
		//expand to 2-4 players 


		// Position the camera in the center.
		Vector3 newCameraPos = Camera.main.transform.position;
		newCameraPos.x = middlePoint.x;
		Camera.main.transform.position = newCameraPos;

		// Find the middle point between players.
		Vector3 vectorBetweenPlayers = player2.position - player1.position;
		middlePoint = player1.position + 0.5f * vectorBetweenPlayers;

		// Calculate the new distance.
		distanceBetweenPlayers = vectorBetweenPlayers.magnitude;
		cameraDistance = (distanceBetweenPlayers / 2.0f / aspectRatio) / tanFov;

		//crossproduct of transforms
		cross = Vector3.Cross(player1.position, player2.position); 

		// Set camera to new position.
		Vector3 dir = (Camera.main.transform.position - middlePoint).normalized;
		Camera.main.transform.position = middlePoint + dir * (cameraDistance + DISTANCE_MARGIN) - cross;
		//Camera.main.transform.position 
	}
}
