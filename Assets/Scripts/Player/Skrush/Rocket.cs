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
    private bool isThrusted;
    private bool isDisabled;
    private AudioSource audioSource;
    private ParticleSystem particles;
    private SpriteRenderer _renderer;

    private void Start()
    {
        spawnTime = Time.time;
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = fireDirection * initialSpeed;

        var hurtboxTrigger = hurtboxTriggerObject.GetComponent<TriggerCallback>();
        hurtboxTrigger.Init(OnHurtboxTriggerEnter2D, null, null);
        audioSource = GetComponent<AudioSource>();
        particles = GetComponent<ParticleSystem>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Time.time - spawnTime > lifespan)
        {
            Destroy(gameObject, 3.0f);
        }
        else if (!isThrusted && Time.time - spawnTime > thrustActivationDelay)
        {
            isThrusted = true;
            particles.Play();
            audioSource.PlayOneShot(thrustSound);
        }
    }

    private void FixedUpdate()
    {
        if (isDisabled)
        {
            _rigidBody.velocity = Vector2.zero;
        }
        else if (isThrusted)
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
        isDisabled = true;
        particles.Stop();
        _renderer.enabled = false;

        Instantiate(explosion, gameObject.transform.position, Quaternion.identity);

        Destroy(gameObject, 3.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDisabled)
            return;

        Explode();
    }

    private void OnHurtboxTriggerEnter2D(Collider2D collider)
    {
        if (isDisabled)
            return;

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
