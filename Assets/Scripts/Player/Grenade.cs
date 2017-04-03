using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {
    
    public GameObject explosion;
    public float armTime = 1.0f;
    public float explosionDelay = 2.0f;

    private float timeCreated;
    private bool col = false;
    private Vector3 collisionOffset;
    private GameObject collidedObj;
    private Rigidbody2D _rigidBody;
    private Vector2 fireDirection;
    private float startingSpeed;
    private ParticleSystem armedEffect;

    void Start ()
    {
        timeCreated = Time.time;

        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = fireDirection * startingSpeed;

        var hurtboxTrigger = GetComponentInChildren<TriggerCallback>();
        hurtboxTrigger.Init(OnHurtboxTriggerEnter2D, OnHurtboxTriggerExit2D, OnHurtboxTriggerStay2D);

        armedEffect = GetComponent<ParticleSystem>();
    }
	
	void Update ()
    {
        var armed = Time.time - timeCreated > armTime;
        var readyToExplode = Time.time - timeCreated > explosionDelay + armTime;

        if (armed)
        {
            if (!armedEffect.isPlaying)
            {
                armedEffect.Play();
            }
        }

        if (readyToExplode)
        {
            var explosionInstance = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (col && collidedObj != null)
        {
            gameObject.transform.position = collidedObj.transform.position + collisionOffset;
        }
   	}

    public void Initialize(Vector2 direction, float speed)
    {
        startingSpeed = speed;
        fireDirection = direction.normalized;
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

    private void OnHurtboxTriggerEnter2D(Collider2D collider)
    {

    }

    private void OnHurtboxTriggerExit2D(Collider2D collider)
    {

    }

    private void OnHurtboxTriggerStay2D(Collider2D collider)
    {
        var armed = Time.time - timeCreated > armTime;
        if (!col && armed)
        {
            collisionOffset = gameObject.transform.position - collider.gameObject.transform.position;
            collidedObj = collider.gameObject;
            col = true;
        }
    }
}
