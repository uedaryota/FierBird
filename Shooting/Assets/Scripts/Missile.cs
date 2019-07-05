using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float range = 100f;
    public int damagePerShot = 20;
    public float timeBetweenBullets = 0.15f;

    float timer;
    float limittime;
    private float rad;
    public GameObject missile;
    public Transform muzzle;
    public float speed = 10;
    private Vector3 Position;


    void Start()
    {
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.X) && timer >= timeBetweenBullets && Time.timeScale != 0)
        {
            limittime += Time.deltaTime;
            if (limittime >= 0.3f)
            {
                Shot();
                limittime = 0;
            }
        }
    }
    void Shot()
    {
        timer = 0f;
        //弾丸の複製
        GameObject bullets = Instantiate(missile) as GameObject;

        Vector3 force;

        force = this.gameObject.transform.forward * speed;

        //Rigidbodyに力を加えて発射
        bullets.GetComponent<Rigidbody>().AddForce(force);

        //弾丸の位置を調整
        bullets.transform.position = muzzle.position;

        
    }
}
