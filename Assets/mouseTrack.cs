using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseTrack : MonoBehaviour {

    GameObject playerObj;
    Transform playerTrans;
    Transform boomerangTrans;
    Vector3 playerPos;
    Vector3 mousePos;
    Vector3 boomerangPos;
    float difX;
    float difY;
    float angle;
    float currentTime;
    bool thrown;


    void Start ()
    {
        playerObj   = GameObject.Find("player");
        playerTrans = playerObj.GetComponent<Transform>();
        boomerangTrans = gameObject.GetComponent<Transform>();
    }
	void Update ()
    {
        playerPos = playerTrans.position;
        mousePos = Input.mousePosition;
        difX = playerPos.x - mousePos.x;
        difY = playerPos.y - mousePos.y;

        angle = Mathf.Atan(difY/difX);
        if(difX < 0.0f && difY < 0.0f && !thrown)
        {
            boomerangPos = new Vector3(playerPos.x + 1.5f * Mathf.Cos(angle), playerPos.y + 1.5f * Mathf.Sin(angle), 0.0f);
        }
        else if(difX > 0.0f && !thrown)
        {
            angle = -angle;
            boomerangPos = new Vector3(playerPos.x - 1.5f * Mathf.Cos(angle), playerPos.y + 1.5f * Mathf.Sin(angle), 0.0f);
        }
        else if(difY < 0.0f && !thrown)
        {
            boomerangPos = new Vector3(playerPos.x + 1.5f * Mathf.Cos(angle), playerPos.y + 1.5f * Mathf.Sin(angle), 0.0f);
        }
        else if(!thrown)
        {
            boomerangPos = new Vector3(playerPos.x + 1.5f * Mathf.Cos(angle), playerPos.y + 1.5f * Mathf.Sin(angle), 0.0f);
        }
        gameObject.GetComponent<Transform>().position = boomerangPos;
        if(Input.GetMouseButtonDown(0) && !thrown)
        {
            thrown = true;
            currentTime = Time.time;
        }
        if(thrown)
        {
            gameObject.GetComponent<Transform>().Translate(Mathf.Sin((Time.time - currentTime)*3)*Mathf.Cos(angle), Mathf.Sin((Time.time - currentTime)*3) * Mathf.Sin(angle),0);
        }
        if((Time.time - currentTime) == (2*Mathf.PI)  && thrown)
        {
            Destroy(GameObject.Find("Boomerang"));
        }

    }
}
