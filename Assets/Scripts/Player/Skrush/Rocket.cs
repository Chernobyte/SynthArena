using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    public float initialSpeed = 1.0f;
    public float thrustSpeed = 15.0f;
    public float thrustActivationDelay = 1.0f;
    public float lifespan = 5.0f;
    public GameObject hurtboxTriggerObject;
    public GameObject explosion;
    public AudioClip thrustSound;

    private float spawnTime;
    private Player parentPlayer;
    private Rigidbody2D _rigidBody;
    private Vector2 fireDirection;
    private bool isActivated;
    private AudioSource audioSource;

    private void Start()
    {
        spawnTime = Time.time;
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = fireDirection * initialSpeed;

        var hurtboxTrigger = hurtboxTriggerObject.GetComponent<TriggerCallback>();
        hurtboxTrigger.Init(OnHurtboxTriggerEnter2D, null, null);
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Time.time - spawnTime > lifespan)
        {
            Destroy(gameObject);
        }
        else if (!isActivated && Time.time - spawnTime > thrustActivationDelay)
        {
            isActivated = true;
            audioSource.PlayOneShot(thrustSound);
        }
    }

    private void FixedUpdate()
    {
        if (isActivated)
        {
            _rigidBody.velocity = fireDirection * thrustSpeed;
        }
        else
        {
            _rigidBody.velocity -= _rigidBody.velocity * 0.1f;
        }
    }

    public void Initialize(Vector2 direction, Player player)
    {
        parentPlayer = player;

        fireDirection = direction.normalized;
    }

    private void Explode()
    {
        Instantiate(explosion, gameObject.transform.position, Quaternion.identity);

        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Explode();
    }

    private void OnHurtboxTriggerEnter2D(Collider2D collider)
    {
        var hitbox = collider.gameObject.GetComponent<HitboxCallback>();

        if (hitbox != null)
        {
            if (hitbox.parentPlayer != parentPlayer)
            {
                Explode();
            }
        }
    }
}
