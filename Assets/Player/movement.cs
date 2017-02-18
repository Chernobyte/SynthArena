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
    float fallSpd   = 1.0f;
    bool onTheGround= true;
    int jump = 0;

    private void Start ()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        playerBC = gameObject.GetComponent<BoxCollider2D>();
        groundObj= GameObject.Find("floor");
    }

    private void Update()
    {
        gameObject.GetComponent<Transform>().rotation = Quaternion.identity;
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (move < maxSpd)
            {
                move = move + 2.0f;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (move > (maxSpd * -1))
            {
                move = move - 2.0f;
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
        playerRB.velocity = new Vector2(move, playerRB.velocity.y);

        if (Input.GetKeyDown(KeyCode.W) && jump<1)
        {
            jump++;
            playerRB.AddForce(new Vector2(0f, jmpStr));
            onTheGround = false;
        }

        if (playerBC.IsTouching(groundObj.GetComponent<BoxCollider2D>()))
        {
            jump = 0;
        }
                    
        if(Input.GetKey(KeyCode.S))
        {
            playerRB.AddForce(new Vector2(0f, fallStr));
        }

        

    }
}
