using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwirlSpin : MonoBehaviour {

    public float spinInterval = 1.0f;

	void Start ()
    {	
	}

    void Update ()
    {
        var lerpFactor = Time.time % 1.0f;
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(0, 360, lerpFactor));
	}
}
