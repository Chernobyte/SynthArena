using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	GameObject platform;
    bool bounce;
    Vector3 normalVec;
    Vector3 startVec;
    Vector3 newVec;

	// Use this for initialization
	void Start () {
		platform = GameObject.FindWithTag ("Platform");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 diff = transform.position - platform.transform.position;

		if (diff.magnitude > 50f)
			Destroy (gameObject);
	}

    public void toggleBounce(bool active)
    {
        bounce = active;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (!bounce)
        {
            if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(bounce)
        {
            if(hit.gameObject.CompareTag("Platform") || hit.gameObject.CompareTag("Wall"))
            {
                normalVec = hit.normal;
                startVec = hit.gameObject.GetComponent<Rigidbody2D>().velocity;
                float angle = Mathf.Atan2(startVec.x - normalVec.x, startVec.y - normalVec.y);
            }
        }
    }
}
