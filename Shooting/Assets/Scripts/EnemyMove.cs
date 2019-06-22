using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //Rigidbodyを変数に入れる
    Rigidbody rb;
    public float speed = 0.01f;//移動スピード
    public float x = 0.0f;
    public float z = 12.0f;

    void Start()
    {
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.MovePosition(transform.position + new Vector3(x, 0, z) * -speed);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Wall")
        {
            x *= -1;
        }
<<<<<<< HEAD
        if(col.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
=======
        if(col.gameObject.tag == "bullet" || col.gameObject.tag == "Player" || col.gameObject.tag == "EnemyDeath")
        {
            Destroy(gameObject);
        }
>>>>>>> 0578e96033a1fb6df06ece71c5d7b8503c28238b
    }
}
