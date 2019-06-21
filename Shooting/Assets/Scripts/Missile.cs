using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float range = 100f;
    public int damagePerShot = 20;
    public float timeBetweenBullets = 0.15f;

    float timer;
    private float rad;
    public GameObject missile;
    public Transform muzzle;

    private Vector3 Position;

    public float Speed;

    void Start()
    {
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.X) && timer >= timeBetweenBullets && Time.timeScale != 0)
        {
            Shot();
        }
    }
    void Shot()
    {
        timer = 0f;
        //弾丸の複製
        GameObject bullets = Instantiate(missile) as GameObject;

        //弾丸の位置を調整
        bullets.transform.position = muzzle.position;

        
    }
}
