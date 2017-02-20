using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseTrack : MonoBehaviour {

    public Rigidbody2D Bullet;

    GameObject playerObj;
    Transform playerTrans;
    Transform gunTrans;
    Vector3 playerPos;
    Vector3 mousePos;
    Vector3 gunPos;

    float difX;
    float difY;
    float angle;
    float gunX;
    float gunY;
    float bulletSpeed =200f;


    void Start ()
    {
        playerObj   = GameObject.Find("player");
        playerTrans = playerObj.GetComponent<Transform>();
        gunTrans = gameObject.GetComponent<Transform>();
    }
	void Update ()
    {
        playerPos = playerTrans.position;
        mousePos = Input.mousePosition;
        difX = playerPos.x - mousePos.x;
        difY = playerPos.y - mousePos.y;

        angle = Mathf.Atan(difY/difX);
        if (difX < 0.0f && difY < 0.0f)//(1)
        {
            gunX = playerPos.x + 1.5f * Mathf.Cos(angle);
            gunY = playerPos.y + 1.5f * Mathf.Sin(angle);
            gunPos = new Vector3(gunX, gunY, -4.0f);
        }
        else if (difX < 0.0f && difY > 0.0f)//(2)
        {
            //angle -= 90;
            gunX = playerPos.x + 1.5f * Mathf.Cos(angle);
            gunY = playerPos.y + 1.5f * Mathf.Sin(angle);
            gunPos = new Vector3(gunX, gunY, -4.0f);
        }
        else if (difY > 0.0f && difY < 0.0f)//(3)
        {
            //angle += 90;
            gunX = playerPos.x + 1.5f * Mathf.Cos(angle);
            gunY = playerPos.y + 1.5f * Mathf.Sin(angle);
            gunPos = new Vector3(gunX,gunY, -4.0f);
        }
        else//(4)
        {
            //angle += 180;
            gunX = playerPos.x + 1.5f * Mathf.Cos(angle);
            gunY = playerPos.y + 1.5f * Mathf.Sin(angle);
            gunPos = new Vector3(gunX, gunY, -4.0f);
        }
        gameObject.GetComponent<Transform>().position = gunPos;

        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody2D bullet;
            bullet = (Rigidbody2D)Instantiate(Bullet, gunPos, Quaternion.identity);
            bullet.GetComponent<bulletData>().angle = angle;
            bullet.AddForce(new Vector2(bulletSpeed*(gunX-playerPos.x), bulletSpeed * (gunY -playerPos.y)));
        }

    }
}
