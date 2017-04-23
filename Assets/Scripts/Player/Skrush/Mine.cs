using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject hurtboxTriggerObject;
    public float rotationInterval = 1.0f;

    private bool hasCollided;
    private ContactPoint2D contactPoint;
    private Vector3 collisionOffset;
    private GameObject collidedObj;
    private Player parentPlayer;
    private Vector2 fireDirection;
    private Rigidbody2D _rigidBody;
    private float rotationProgress;
    

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = fireDirection * speed;

        var hurtboxTrigger = hurtboxTriggerObject.GetComponent<TriggerCallback>();
        hurtboxTrigger.Init(OnHurtboxTriggerEnter2D, null, null);
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
        if (hasCollided && collidedObj != null)
        {
            _rigidBody.simulated = false;
            transform.position = collidedObj.transform.position + collisionOffset;

            transform.rotation = Quaternion.FromToRotation(Vector3.right, contactPoint.normal);
        }
        else
        {
            rotationProgress += Time.deltaTime / rotationInterval;
            if (rotationProgress > 1)
                rotationProgress = 0;

            transform.rotation = Quaternion.AngleAxis(360 * rotationProgress, Vector3.forward);
        }
    }

    public void Initialize(Vector2 direction, Player player)
    {
        parentPlayer = player;

        fireDirection = direction.normalized;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!hasCollided)
        {
            hasCollided = true;

            collisionOffset = gameObject.transform.position - collision.gameObject.transform.position;
            collidedObj = collision.gameObject;
            contactPoint = collision.contacts[0];
        }
    }

    private void OnHurtboxTriggerEnter2D(Collider2D collider)
    {

    }
}
