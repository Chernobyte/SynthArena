using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityTwo : MonoBehaviour {

    private float timeTill;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Time.time - timeTill > 6)
            gameObject.GetComponent<Player>().bouncing = false;
    }

    public void fire(Transform gun)
    {
        gameObject.GetComponent<Player>().bouncing = true;
        timeTill = Time.time;
    }
}
