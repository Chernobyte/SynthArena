using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float explosionForce = 5.0f;
    Vector2 explosionVector;
    public int damage = 100;
    public float stunTime = 0.1f;

    private ParticleSystem particle;
    private AudioSource audioSource;
    
	void Start ()
    {
        particle = GetComponent<ParticleSystem>();
	}
	
	void FixedUpdate ()
    {
		if (!particle.IsAlive())
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            var player = coll.GetComponent<Player>();

            explosionVector = new Vector2 (coll.transform.position.x - transform.position.x, coll.transform.position.y - transform.position.y);
            explosionVector.Normalize();

            explosionVector.y = Mathf.Abs(explosionVector.y);

            player.TakeHit(explosionForce*explosionVector, damage, stunTime);
        }
    }
}
