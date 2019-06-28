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
        if(col.gameObject.tag == "PlayerBullet" || col.gameObject.tag == "Player" || col.gameObject.tag == "EnemyDeath")
        {
            Destroy(gameObject);
<<<<<<< HEAD
=======
        }

        var hit = col.gameObject;
        var health = hit.GetComponent<PlayerHealth>();
        if (health != null)
        {
            health.TakeDamage(10);
>>>>>>> 7fbd36475f0256c1f35ce6f33634f2fdedef1153
        }
    }
}
