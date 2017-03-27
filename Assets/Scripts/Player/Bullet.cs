using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	GameObject platform;
    bool bounce;
    float bounceTime = 2;
    float bounceDuration = 0;
    Vector2 normalVec;
    Vector2 startVec;
    Vector2 newVec;
    Vector2 u;
    Vector2 w;

	// Use this for initialization
	void Start () {
		platform = GameObject.FindWithTag ("Platform");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 diff = transform.position - platform.transform.position;

		if (diff.magnitude > 50f)
			Destroy (gameObject);

        if(Time.time - bounceDuration > bounceTime)
        {
            bounce = false;
            bounceDuration = 0;
        }
	}

    public void setBounce(bool active)
    {
        bounce = active;
        bounceDuration = Time.time;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (!bounce)
        {
            if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Wall"))
            {
                Destroy(gameObject);
            }
        }
        else
        {
           if( collision.gameObject.CompareTag("Platform"))
           {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, -gameObject.GetComponent<Rigidbody2D>().velocity.y);
            }
            else if (collision.gameObject.CompareTag("Wall"))
           {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-gameObject.GetComponent<Rigidbody2D>().velocity.x, gameObject.GetComponent<Rigidbody2D>().velocity.y);
           }
           if (collision.gameObject.CompareTag("Player"))
           {
                Destroy(gameObject);
           }
        }
   }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("Collide");
        if(bounce)
        {
            if(hit.gameObject.CompareTag("Platform") || hit.gameObject.CompareTag("Wall"))
            {
                Debug.Log("bounce");
                normalVec = hit.normal;
                startVec = hit.gameObject.GetComponent<Rigidbody2D>().velocity;
                float angle = Mathf.Atan2(startVec.y - normalVec.y, startVec.x - normalVec.x);
                u = normalVec * ((normalVec.magnitude * startVec.magnitude * Mathf.Cos(angle)) / (normalVec.magnitude * normalVec.magnitude));
                w = startVec - u;
                newVec = w - u;
                hit.gameObject.GetComponent<Rigidbody2D>().velocity = newVec;
            }
        }
    }
}
