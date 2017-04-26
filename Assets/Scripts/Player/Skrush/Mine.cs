using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public float rotationInterval = 1.0f;
    public Color stuckColor;
    public Color armedColor;
    public GameObject explosion;
    public float timeToActivate;
    public AudioClip armedSound;
    public SpriteRenderer glowSprite;

    private bool hasCollided;
    private ContactPoint2D contactPoint;
    private Vector3 collisionOffset;
    private GameObject collidedObj;
    private Vector2 fireDirection;
    private Rigidbody2D _rigidBody;
    private float rotationProgress;
    private float startingSpeed;
    private bool isArmed;
    private AudioSource audioSource;
    private bool explosionScheduled;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = fireDirection * startingSpeed;

        var hurtboxTrigger = GetComponentInChildren<TriggerCallback>();
        hurtboxTrigger.Init(OnHurtboxTriggerEnter2D, null, OnHurtboxTriggerStay2D);

        audioSource = GetComponent<AudioSource>();

        StartCoroutine(BeginDestroyCountdown());
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
        if (hasCollided && collidedObj != null)
        {
            _rigidBody.constraints = RigidbodyConstraints2D.FreezeAll;
            transform.position = collidedObj.transform.position + collisionOffset;

            transform.rotation = Quaternion.FromToRotation(Vector3.up, contactPoint.normal);
        }
        else
        {
            rotationProgress += Time.deltaTime / rotationInterval;
            if (rotationProgress > 1)
                rotationProgress = 0;

            transform.rotation = Quaternion.AngleAxis(360 * rotationProgress, Vector3.forward);
        }
    }

    private IEnumerator BeginDestroyCountdown()
    {
        yield return new WaitForSeconds(5.0f);

        if (!hasCollided)
            Destroy(gameObject);
    }

    private IEnumerator BeginArmCountdown()
    {
        yield return new WaitForSeconds(timeToActivate);

        if (explosionScheduled)
        {
            Explode();
        }
        else
        {
            glowSprite.color = armedColor;
            isArmed = true;
            audioSource.PlayOneShot(armedSound);
        }
    }

    public void Initialize(Vector2 direction, float speed, Skrush parent)
    {
        startingSpeed = speed;
        fireDirection = direction.normalized;
    }

    public void ScheduleExplode()
    {
        if (!isArmed)
        {
            explosionScheduled = true;
        }
        else
        {
            Explode();
        }
    }

    private void Explode()
    {
        Instantiate(explosion, gameObject.transform.position, Quaternion.identity);

        Destroy(gameObject);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!hasCollided)
        {
            hasCollided = true;

            collisionOffset = gameObject.transform.position - collision.gameObject.transform.position;
            collidedObj = collision.gameObject;
            contactPoint = collision.contacts[0];

            glowSprite.color = stuckColor;

            StartCoroutine(BeginArmCountdown());
        }
    }

    private void OnHurtboxTriggerEnter2D(Collider2D collider)
    {
    }

    private void OnHurtboxTriggerStay2D(Collider2D collider)
    {
        //if (!isArmed)
        //    return;

        //var hitbox = collider.gameObject.GetComponent<HitboxCallback>();

        //if (hitbox != null)
        //{
        //    Explode();
        //}
    }
}
