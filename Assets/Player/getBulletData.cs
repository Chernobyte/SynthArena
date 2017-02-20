using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getBulletData : MonoBehaviour {

    public float bulletAngle;
    private float xForce;
    private float yForce;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject != GameObject.Find("floor"))
        {
            bulletAngle = coll.gameObject.GetComponent<bulletData>().angle;
            xForce = 300f * Mathf.Cos(bulletAngle);
            yForce = 300f * Mathf.Sin(bulletAngle);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(xForce, yForce));
            Debug.Log("bleh");
            //destroy bulllet
        }
    }
}
