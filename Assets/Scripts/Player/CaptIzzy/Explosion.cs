using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float explosionForce;
    Vector2 explosionVector;
    public int damage = 100;

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
            explosionVector = new Vector2 (coll.gameObject.transform.position.x - gameObject.transform.position.x, coll.gameObject.transform.position.y - gameObject.transform.position.y);
            explosionVector.Normalize();
            coll.gameObject.GetComponent<Player>().TakeHit(explosionForce*explosionVector,300,.4f);
        }
    }
}
