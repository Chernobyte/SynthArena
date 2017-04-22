using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkrushA2 : MonoBehaviour {

    private float timeTill;
    private ParticleSystem effect;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Time.time - timeTill > 6)
        {
            gameObject.GetComponent<CaptIzzy>().bouncing = false;
            if (effect != null)
                effect.Stop();
        }
    }

    public void fire(ParticleSystem abilityEffect)
    {
        gameObject.GetComponent<CaptIzzy>().bouncing = true;
        timeTill = Time.time;
        effect = abilityEffect;
        effect.Play();
    }
}
