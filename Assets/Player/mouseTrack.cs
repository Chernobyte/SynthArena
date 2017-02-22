using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseTrack : MonoBehaviour {

    public GameObject Bullet;

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

    bool rateOfFire;


    void Start ()
    {
        playerObj   = GameObject.Find("player");
        playerTrans = playerObj.GetComponent<Transform>();
        gunTrans = gameObject.GetComponent<Transform>();
    }
	void Update ()
    {
        if(!rateOfFire)
        {
            if (Time.time % 1 == 0)
                rateOfFire = true;
        }
        playerPos = playerTrans.position;

        if ((Input.GetAxis("yRightJ") > .3 || Input.GetAxis("yRightJ") < -.3) && (Input.GetAxis("xRightJ") > .3 || Input.GetAxis("xRightJ") < -.3))
        {
            angle = Mathf.Atan(Input.GetAxis("xRightJ") / Input.GetAxis("yRightJ"));
            Debug.Log("Y:");
            Debug.Log(Input.GetAxis("yRightJ"));
            Debug.Log("X:");
            Debug.Log(Input.GetAxis("xRightJ"));
            Debug.Log("angle:");
            Debug.Log(angle);
        }
        else
        {
            angle = 0;
        }

        if (Input.GetAxis("xRightJ") < 0f)
        {
            if (Input.GetAxis("yRightJ") < 0f)
            {
                angle = angle - (Mathf.PI / 2f);
                gunX = playerPos.x - 2f * Mathf.Cos(angle);
                gunY = playerPos.y - 2f * Mathf.Sin(angle);
                gunPos = new Vector3(gunX, gunY, -4.0f);
            }
            else
            {
                angle = Mathf.PI / 2f + angle;
                gunX = playerPos.x - 2f * Mathf.Cos(angle);
                gunY = playerPos.y - 2f * Mathf.Sin(angle);
                gunPos = new Vector3(gunX, gunY, -4.0f);
            }
        }
        else
        {
            gunX = playerPos.x + 2f * Mathf.Cos(angle);
            gunY = playerPos.y + 2f * Mathf.Sin(angle);
            gunPos = new Vector3(gunX, gunY, -4.0f);
        }
       
        gameObject.GetComponent<Transform>().position = gunPos;

        if (Input.GetAxis("RT") > .2f && rateOfFire)
        {
            GameObject bullet;
            bullet = (GameObject)Instantiate(Bullet, gunPos, Quaternion.identity);
            bullet.GetComponent<bulletData>().angle = angle;
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * (gunX - playerPos.x), bulletSpeed * (gunY - playerPos.y)));
            rateOfFire = false;
        }

    }
}
