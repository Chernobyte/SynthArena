using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float knockbackStrength = 2.0f;
    public Vector2 knockbackDirection;
    public float lifespan = 5.0f;

    private int numBouncesRemaining = 0;
    private float spawnTime;
    private Vector2 oldVelocity;
    private Rigidbody2D _rigidBody; 

	private void Start()
    {
        spawnTime = Time.time;
        _rigidBody = GetComponent<Rigidbody2D>();
	}

	private void Update()
    {
        Debug.Log(Time.time);
        if (Time.time - spawnTime > lifespan)
        {
            Destroy(gameObject);
        }
	}

    private void FixedUpdate()
    {
        oldVelocity = _rigidBody.velocity;
    }

    public void Initialize(int maxBounces)
    {
        numBouncesRemaining = maxBounces;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var contact = collision.contacts[0];

        if (numBouncesRemaining > 0)
        {
            numBouncesRemaining--;

            var reflectedVelocity = Vector2.Reflect(oldVelocity, contact.normal);
            var rotation = Quaternion.FromToRotation(oldVelocity, reflectedVelocity);
            _rigidBody.velocity = reflectedVelocity;
            transform.rotation = rotation * transform.rotation;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
