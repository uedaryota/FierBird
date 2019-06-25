using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    //bullet prefab
    public GameObject bullet;

    //弾丸発射点
    public Transform muzzle;

    private Vector3 velocity;
    private Vector3 X;
    private Vector3 Y;
    //弾丸の速度
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Zキーが押された時
        if(Input.GetButton("Z"))
        {
            
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
}
