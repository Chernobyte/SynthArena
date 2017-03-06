using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySelf : MonoBehaviour {
    float creationTime;
    float secondsTillDestruction = 1f;

	void Start ()
    {
        creationTime = Time.time;
	}

	void Update ()
    {
		if(creationTime < Time.time - secondsTillDestruction)
        {
            DestroyImmediate(gameObject);
        }
	}
}
