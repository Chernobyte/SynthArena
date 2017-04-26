using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overcharge : MonoBehaviour {

    public float duration = 3;

    private float timeTill;
    private ParticleSystem effect;
    private float initialFireRate;
    private CaptIzzy izzy;

	void Start ()
    {
        izzy = gameObject.GetComponent<CaptIzzy>();
        initialFireRate = izzy.fireRate;
	}

	void FixedUpdate ()
    {
		if(Time.time - timeTill > duration)
        {
            gameObject.GetComponent<CaptIzzy>().bouncing = false;
            if (effect != null)
                effect.Stop();
            izzy.fireRate = initialFireRate;
        }
    }

    public void fire(ParticleSystem abilityEffect)
    {
        
        izzy.bouncing = true;
        izzy.fireRate = initialFireRate / 2.0f;
        timeTill = Time.time;
        effect = abilityEffect;
        effect.Play();
    }
}
