using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FireGrenade : MonoBehaviour
{
    public float grenadeSpeed = 10.0f;

    public GameObject grenade;

	void Start ()
    {
     
    }

	void Update ()
    {

    }

    public void fire(Transform spawnLocation, Vector2 aimDirection)
    {
        var grenadeInstance = Instantiate(grenade, spawnLocation.position, Quaternion.identity);

        grenadeInstance.GetComponent<Grenade>().Initialize(aimDirection, grenadeSpeed);
    }

    

}
