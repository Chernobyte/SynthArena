using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float knockbackStrength = 2.0f;
    public Vector2 knockbackDirection;
    public int damage = 10;
    public float stunTime = 1.0f;
    public float bulletSpeed = 10.0f;
    public float lifespan = 5.0f;
    public GameObject hurtboxTriggerObject;

    private int numBouncesRemaining = 0;
    private float spawnTime;
    private Vector2 oldVelocity;
    private Rigidbody2D _rigidBody;
    private Player parentPlayer;
    private Vector2 fireDirection;

	private void Start()
    {
        spawnTime = Time.time;
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = fireDirection * bulletSpeed;

        var hurtboxTrigger = hurtboxTriggerObject.GetComponent<TriggerCallback>();
        hurtboxTrigger.Init(OnHurtboxTriggerEnter2D, OnHurtboxTriggerExit2D, null);
    }

	private void Update()
    {
        if (Time.time - spawnTime > lifespan)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        oldVelocity = _rigidBody.velocity;
    }

    public void Initialize(int maxBounces, Vector2 direction, Player player)
    {
        numBouncesRemaining = maxBounces;
        parentPlayer = player;

        fireDirection = direction.normalized;
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

    private void OnHurtboxTriggerEnter2D(Collider2D collider)
    {
        var hitbox = collider.gameObject.GetComponent<HitboxCallback>();

        if (hitbox != null)
        {
            var player = hitbox.parentPlayer;

            if (player != parentPlayer)
            {
                Vector2 trueKnockbackDirection;

                if (_rigidBody.velocity.x > 0)
                {
                    trueKnockbackDirection = new Vector2(knockbackDirection.x, knockbackDirection.y);
                }
                else
                {
                    trueKnockbackDirection = new Vector2(-knockbackDirection.x, knockbackDirection.y);
                }

                trueKnockbackDirection.Normalize();

                player.TakeHit(trueKnockbackDirection * knockbackStrength, damage, stunTime);
                Destroy(gameObject);
            }
        }
    }

    private void OnHurtboxTriggerExit2D(Collider2D collider)
    {

    }
}
