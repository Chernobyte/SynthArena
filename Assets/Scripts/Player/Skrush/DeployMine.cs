using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeployMine : MonoBehaviour
{
    public float mineSpeed = 25.0f;

    public GameObject mine;

    void Start()
    {

    }

    void Update()
    {

    }

    public void fire(Transform spawnLocation, Vector2 aimDirection)
    {
        var grenadeInstance = Instantiate(mine, spawnLocation.position, Quaternion.identity);

        grenadeInstance.GetComponent<Grenade>().Initialize(aimDirection, mineSpeed);
    }



}
