﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkrushA1 : MonoBehaviour {

    Transform gunTrans = null;
    public float grenadeSpeed = 25.0f;

    public GameObject grenade;

    void Start()
    {

    }

    void Update()
    {

    }

    public void fire(Transform spawnLocation, Vector2 aimDirection)
    {
        var grenadeInstance = Instantiate(grenade, spawnLocation.position, Quaternion.identity);

        grenadeInstance.GetComponent<Grenade>().Initialize(aimDirection, grenadeSpeed);
    }
}
