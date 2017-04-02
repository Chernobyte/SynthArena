using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {
    
    public GameObject explosion;
    public float pinTime = 2.0f;
    public float armTime = 1.0f;

    private float timeCreated;
    private bool col = false;
    private Vector3 collisionOffset;
    private GameObject collidedObj;
    

	void Start ()
    {
        timeCreated = Time.time;
	}
	
	void Update ()
    {
        var armed = Time.time - timeCreated > armTime;
        var readyToExplode = Time.time - timeCreated > pinTime + armTime;

        if (armed)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (readyToExplode)
        {
            GameObject explode = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (col && collidedObj != null)
        {
            gameObject.transform.position = collidedObj.transform.position + collisionOffset;
        }
   	}

    private void OnCollisionStay2D(Collision2D collision)
    {
        var armed = Time.time - timeCreated > armTime;
        if (!col && armed)
        {
            collisionOffset = gameObject.transform.position - collision.gameObject.transform.position;
            collidedObj = collision.gameObject;
            col = true;
        }
    }
}
