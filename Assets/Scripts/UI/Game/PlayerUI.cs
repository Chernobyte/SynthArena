using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

    public int playerId;
    public Image playerIcon;
    public Image healthFillBackground;
    public Image healthFillMask;
    public Image healthFillColor;
    public Image A1Icon;
    public Image A1Fill;
    public Image A2Icon;
    public Image A2Fill;
    public Text LivesText;
    public Text HealthText;
    public Text RespawnText;
    public float fillDampSpeed = 0.01f;

    private float targetFillAmount;
    private float A1FillAmount;
    private float A2FillAmount;
    private float refFillSpeed;
    private float refHealthTickSpeed;
    private int targetHealth;
    private int currentHealthDisplayValue;
    private int maxHealthDisplayValue;
    private int livesRemaining;
    private Color InactiveColor = Color.grey;
    
    void Start()
    {
        A1Fill.color = new Color(0, 0, 0, .5f);
        A2Fill.color = new Color(0, 0, 0, .5f);
        A1Fill.fillAmount = 0;
        A2Fill.fillAmount = 0;
    }

    private void Update()
    {
        var fillAmount = Mathf.SmoothDamp(healthFillMask.fillAmount, targetFillAmount, ref refFillSpeed, fillDampSpeed);
        healthFillMask.fillAmount = fillAmount;
    }

    public void Init(PlayerSelection selection, int maxHealth, int livesRemaining)
    {
        playerIcon.sprite = selection.characterIcons.characterIcon;
        A1Icon.sprite = selection.characterIcons.ability1Icon;
        A2Icon.sprite = selection.characterIcons.ability2Icon;

        healthFillColor.color = selection.playerColor;
        currentHealthDisplayValue = maxHealth;

        this.livesRemaining = livesRemaining;
        UpdateRespawnTimer(0);
    }

    public void UpdateHealthBar(int currentHealth, int maxHealth, int livesRemaining)
    {
        targetFillAmount = (float)currentHealth / maxHealth;

        LivesText.text = "x " + livesRemaining;

        HealthText.text = "" + currentHealth + "/" + maxHealth;

        this.livesRemaining = livesRemaining;

        if (livesRemaining <= 0)
            UpdateRespawnTimer(0);
    }

    public void UpdateRespawnTimer(float respawnTimer)
    {
        if (livesRemaining <= 0)
        {
            RespawnText.text = "ELIMINATED";
            SetInactive();
        }
        else if (respawnTimer != 0.0f)
        {
            RespawnText.text = "Respawn: " + respawnTimer.ToString("0.0");
        }
        else
        {
            RespawnText.text = "";
        }
    }

    public void UpdateAbilitiesCD(float currentA1CD, float maxA1CD, float currentA2CD, float maxA2CD)
    {
        A1FillAmount = 1 - currentA1CD/maxA1CD;
        A2FillAmount = 1 - currentA2CD/maxA2CD;

        if (currentA1CD > maxA1CD)
            A1FillAmount = 0;
        else
            A1Fill.fillAmount = A1FillAmount;
        if (currentA2CD > maxA2CD)
            A2FillAmount = 0;
        else
            A2Fill.fillAmount = A2FillAmount;
    }

    private void SetInactive()
    {
        playerIcon.color = InactiveColor;
        healthFillBackground.color = InactiveColor;
        healthFillMask.color = InactiveColor;
        healthFillColor.color = InactiveColor;
        A1Icon.color = InactiveColor;
        A1Fill.color = InactiveColor;
        A2Icon.color = InactiveColor;

        LivesText.color = InactiveColor;
        HealthText.color = InactiveColor;
        RespawnText.color = InactiveColor;
    }
}
