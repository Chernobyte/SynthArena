using System.Collections;
using System.Collections.Generic;
using System.Linq;
using XInputDotNetPure;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
    protected int playerNumber;
    protected PlayerIndex playerIndex;

    public int maxHealth = 2000;
    protected int currentHealth;
    public int maxLives = 3;
    protected int currentLives;

    public float maxSpeed = 10.0f;
    public float acceleration = 0.7f;
    public float deceleration = 1.0f;
    protected float currentSpeed;

    public float gravity = -1.0f;
    public float maxFallSpeed = -10.0f;
    public float airDeceleration = 0.1f;
    protected float currentFallSpeed;

    public float maxAbility1Cooldown = 10.0f;
    protected float currentAbility1Cooldown;
    protected float ability1LastUseTime;
    public float maxAbility2Cooldown = 10.0f;
    protected float currentAbility2Cooldown;
    protected float ability2LastUseTime;

    public GameObject topTriggerObject;
    public GameObject bottomTriggerObject;
    public GameObject leftTriggerObject;
    public GameObject rightTriggerObject;
    protected CapsuleCollider2D _collider;
    protected Rigidbody2D _rigidBody;

    protected Transform spawnPoint;
    protected PlayerUI playerUI;
    protected Overlord overlord;
    protected AudioSource audioSource;

    protected GamePadState gamePadState;
    protected GamePadState previousGamePadState;
    protected Vector2 controllerState;
    protected Vector2 controllerStateR;

    protected List<GameObject> touchedPlatforms = new List<GameObject>();
    protected bool onGround = false;
    protected bool onWallLeft = false;
    protected bool onWallRight = false;

    protected bool isDead;
    protected float deathTime;
    protected float respawnDelay = 5;
    protected float currentStunTime;

    protected void Start()
    {
        _rigidBody = gameObject.GetComponent<Rigidbody2D>();
        _collider = gameObject.GetComponent<CapsuleCollider2D>();
        audioSource = gameObject.GetComponent<AudioSource>();

        InitializeTriggers();
        InitializeHurtboxes();

        currentHealth = maxHealth;
        currentLives = maxLives;

        currentAbility1Cooldown = maxAbility1Cooldown;
        currentAbility2Cooldown = maxAbility2Cooldown;
    }

    protected void InitializeTriggers()
    {
        topTriggerObject.GetComponent<TriggerCallback>().Init(OnTopTriggerEnter, OnTopTriggerExit, OnTopTriggerStay);
        bottomTriggerObject.GetComponent<TriggerCallback>().Init(OnBottomTriggerEnter, OnBottomTriggerExit, OnBottomTriggerStay);
        leftTriggerObject.GetComponent<TriggerCallback>().Init(OnLeftTriggerEnter, OnLeftTriggerExit, OnLeftTriggerStay);
        rightTriggerObject.GetComponent<TriggerCallback>().Init(OnRightTriggerEnter, OnRightTriggerExit, OnRightTriggerStay);
    }

    protected void InitializeHurtboxes()
    {
        var hurtboxes = GetComponentsInChildren<HitboxCallback>();
        foreach (var hurtbox in hurtboxes)
        {
            hurtbox.Init(OnHitboxTriggerEnter, OnHitboxTriggerExit, this);
        }
    }

    protected virtual void HandleRespawn()
    {
        if (isDead && currentLives > 0 && Time.time - deathTime > respawnDelay)
        {
            Respawn();
        }
    }

    protected virtual void Respawn()
    {
        currentHealth = maxHealth;
        transform.position = spawnPoint.position;

        isDead = false;
    }

    public virtual void TakeHit(Vector2 force, int damage, float stunTime)
    {
        currentSpeed += force.x;
        currentFallSpeed += force.y;
        currentHealth -= damage;
        currentStunTime = Time.time + stunTime;

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        if (!isDead && currentHealth == 0)
        {
            isDead = true;
            deathTime = Time.time;

            currentLives--;

            if (currentLives == 0)
            {
                overlord.RegisterLoser(this);
            }
            else
            {
                HandleDeath();
            }
        }
    }

    protected virtual void HandleDeath()
    {
    }

    public void Init(int playerNumber, Overlord overlord, PlayerUI playerUI, Transform spawnPoint)
    {
        this.overlord = overlord;
        this.playerNumber = playerNumber;
        this.playerIndex = XInputDotNetHelpers.MapPlayerIdToPlayerIndex(playerNumber);
        this.playerUI = playerUI;
        this.spawnPoint = spawnPoint;
    }

    protected virtual void CalculateAbilityCooldowns()
    {
        if (currentAbility1Cooldown < maxAbility1Cooldown)
        {
            currentAbility1Cooldown = Time.time - ability1LastUseTime;
            if (currentAbility1Cooldown > maxAbility1Cooldown)
                currentAbility1Cooldown = maxAbility1Cooldown;
        }

        if (currentAbility2Cooldown < maxAbility2Cooldown)
        {
            currentAbility2Cooldown = Time.time - ability2LastUseTime;
            if (currentAbility2Cooldown > maxAbility2Cooldown)
                currentAbility2Cooldown = maxAbility2Cooldown;
        }
    }

    protected void CalculateStun()
    {
        if (currentStunTime != 0)
        {
            if (Time.time > currentStunTime)
            {
                currentStunTime = 0;
            }
        }
    }

    protected void UpdatePlayerUI()
    {
        playerUI.UpdateHealthBar(currentHealth, maxHealth, currentLives);
        playerUI.UpdateAbilitiesCD(currentAbility1Cooldown, maxAbility1Cooldown, currentAbility2Cooldown, maxAbility2Cooldown);
    }

    protected virtual void OnLeftTriggerEnter(Collider2D collision)
    {
    }

    protected virtual void OnLeftTriggerStay(Collider2D collision)
    {
    }

    protected virtual void OnLeftTriggerExit(Collider2D collision)
    {
    }

    protected virtual void OnRightTriggerEnter(Collider2D collision)
    {
    }

    protected virtual void OnRightTriggerStay(Collider2D collision)
    {
    }

    protected virtual void OnRightTriggerExit(Collider2D collision)
    {
    }

    protected virtual void OnBottomTriggerEnter(Collider2D collision)
    {
    }

    protected virtual void OnBottomTriggerStay(Collider2D collision)
    {
    }

    protected virtual void OnBottomTriggerExit(Collider2D collision)
    {
    }

    protected virtual void OnTopTriggerEnter(Collider2D collision)
    {
    }

    protected virtual void OnTopTriggerStay(Collider2D collision)
    {
    }

    protected virtual void OnTopTriggerExit(Collider2D collision)
    {
    }

    protected virtual void OnHitboxTriggerEnter(Collider2D collision)
    {

    }

    protected virtual void OnHitboxTriggerExit(Collider2D collision)
    {
    }
}
