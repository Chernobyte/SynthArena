using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

    public int playerId;
    public Image playerFill;
    public Image A1Fill;
    public Image A2Fill;

    private float healthBarFillAmount;
    private float A1FillAmount;
    private float A2FillAmount;
    
    void Start()
    {
        A1Fill.color = new Color(0, 0, 0, .5f);
        A2Fill.color = new Color(0, 0, 0, .5f);
        A1Fill.fillAmount = 0;
        A2Fill.fillAmount = 0;
       
    }

    public void UpdateHealthBar(int currentHealth, int maxHealth)
    {
        healthBarFillAmount = (float)currentHealth / maxHealth;

        playerFill.fillAmount = healthBarFillAmount;
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
}
