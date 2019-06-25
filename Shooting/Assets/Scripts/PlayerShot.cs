﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    private float range = 100f;
    private int damagePerShot = 20;
    private float timeBetweenBullets = 0.15f;

    private float timer;

    //PlayerBulletプレハブ
    public GameObject bullet;

    //弾丸発射点
    public Transform muzzle;

    //弾丸の速度
    public float speed = 10;

    //Startメソッドをコルーチンとして呼び出す
    void Start()
    {
       
    }
    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Z) && timer >= timeBetweenBullets && Time.timeScale != 0)
        {
            Shot();
        }
    }
    void Shot()
    {
        timer = 0f;
        //弾丸の複製
        GameObject bullets = Instantiate(bullet) as GameObject;

        Vector3 force;

        force = this.gameObject.transform.forward * speed;

        //Rigidbodyに力を加えて発射
        bullets.GetComponent<Rigidbody>().AddForce(force);

        //弾丸の位置を調整
        bullets.transform.position = muzzle.position;
    }
}
