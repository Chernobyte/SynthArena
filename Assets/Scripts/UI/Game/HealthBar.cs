using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public int playerId;
    public Image fill;

    private float fillAmount;
    
    void Start()
    {
    }

    public void UpdateHealthBar(int currentHealth, int maxHealth)
    {
        fillAmount = (float)currentHealth / maxHealth;

        fill.fillAmount = fillAmount;
    }
}
