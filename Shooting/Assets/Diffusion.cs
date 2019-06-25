using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diffusion : MonoBehaviour
{
    private float range = 100f;
    private int damagePerShot = 20;
    private float timeBetweenBullets = 0.15f;
    //タイマー
    private float diffusiontimer;
    //弾丸のスピード
    private Vector3 diffusionspeed;
    //弾丸発射点
    public Transform muzzle;
    public GameObject diffusion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += diffusionspeed;
        diffusiontimer += Time.deltaTime;
        if (Input.GetKey(KeyCode.C) && diffusiontimer >= timeBetweenBullets && Time.timeScale != 0)
        {
            diffusionShot();
        }
    }
    void diffusionShot()
    {
        diffusiontimer = 0f;
        //弾丸の複製
        GameObject bullets = Instantiate(diffusion) as GameObject;
    }
}
