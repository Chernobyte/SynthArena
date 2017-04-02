using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AbilityOne : MonoBehaviour
{

    Transform gunTrans = null;
    float grenadeSpawnOffset = .9f;
    float grenadeSpeed = 25f;

    public GameObject grenade;

	void Start ()
    {
     
    }

	void Update ()
    {

    }

    public void fire(Transform gun)
    {
        gunTrans = gun;
        if (gunTrans != null)
        {
            GameObject curGrenade = Instantiate(grenade,
                                            gunTrans.transform.position + (gunTrans.transform.right * grenadeSpawnOffset),
                                            gunTrans.transform.rotation);
            Rigidbody2D rb = curGrenade.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(gunTrans.transform.right.x, gunTrans.transform.right.y) * grenadeSpeed;
        }
    }

    

}
