using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_2 : MonoBehaviour
{
    private float range = 100;
    private float timeBetweenBullets = 0.15f;
    public GameObject bullet1;
    public GameObject bullet2;
    //弾丸発射点
    public Transform muzzle;
    //弾丸の速度
    public float speed = 10;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.V) && timer >= timeBetweenBullets && Time.timeScale != 0)
        {
            Shot();
        }
    }
    void Shot()
    {
        timer = 0f;
        //弾丸の複製
        GameObject bullets1 = Instantiate(bullet1) as GameObject;
        GameObject bullets2 = Instantiate(bullet2) as GameObject;
        Vector3 force;

        force = this.gameObject.transform.forward * speed;

        //Rigidbodyに力を加えて発射
        bullets1.GetComponent<Rigidbody>().AddForce(force);
        bullets2.GetComponent<Rigidbody>().AddForce(force);
        //弾丸の位置を調整
        bullets1.transform.position = muzzle.position+new Vector3(1,0,1);
        bullets2.transform.position = muzzle.position+new Vector3(-1,0,1);
    }
}
