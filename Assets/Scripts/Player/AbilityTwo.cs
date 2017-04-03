using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityTwo : MonoBehaviour {

    private float timeTill;
    private ParticleSystem effect;

	void Start ()
    {
		
	}

	void FixedUpdate ()
    {
		if(Time.time - timeTill > 6)
        {
            gameObject.GetComponent<Player>().bouncing = false;
            if (effect != null)
                effect.Stop();
        }
    }

    public void fire(ParticleSystem abilityEffect)
    {
        gameObject.GetComponent<Player>().bouncing = true;
        timeTill = Time.time;
        effect = abilityEffect;
        effect.Play();
    }
}
