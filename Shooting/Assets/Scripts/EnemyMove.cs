using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //Rigidbodyを変数に入れる
    Rigidbody rb;
    public float speed = 0.01f;//移動スピード
    public float x = 0.0f;
    public float z = 20.0f;

    void Start()
    {
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.MovePosition(transform.position + new Vector3(x, 0, z) * -speed);
    }
}
