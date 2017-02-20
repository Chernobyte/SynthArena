using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontRotate : MonoBehaviour {

	
	void Start ()
    {
		
	}

	void Update ()
    {
        gameObject.GetComponent<Transform>().rotation = Quaternion.identity;
    }
}
