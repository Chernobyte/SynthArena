using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class movement : MonoBehaviour {

    Rigidbody2D playerRB;
    BoxCollider2D playerBC;
    GameObject groundObj;
    float move      = 0.0f;
    float maxSpd    = 6.0f;
    float jmpStr    = 300.0f;
    float fallStr   = -50.0f;
    int jump = 0;

    private void Start ()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        playerBC = gameObject.GetComponent<BoxCollider2D>();
        groundObj= GameObject.Find("floor");
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        

        playerRB.velocity = new Vector2(move, playerRB.velocity.y);

		if ((Input.GetButtonDown("Vertical") || Input.GetButtonDown("Jump")) && jump<1)
        {
            jump++;
            playerRB.AddForce(new Vector2(0f, jmpStr));
        }
        

        if (playerBC.IsTouching(groundObj.GetComponent<BoxCollider2D>()))
        {
            jump = 0;
        }
                    
        if(Input.GetAxis("Vertical") < -.2f)
        {
            playerRB.AddForce(new Vector2(0f, fallStr));
        }

        if (Input.GetAxis("Horizontal") > .2f)
        {
            if (move < maxSpd)
            {
                move = move + Input.GetAxis("Horizontal");
            }
        }
        else if(Input.GetAxis("Horizontal") < -.2f)
        {
            if (move > (maxSpd * -1))
            {
                move = move + Input.GetAxis("Horizontal");
            }
        }
        else
        {
            if (move > 0.0f)
            {
                move = move - .5f;
            }
            else if (move < 0.0f)
            {
                move = move + .5f;
            }
        }


    }
}
