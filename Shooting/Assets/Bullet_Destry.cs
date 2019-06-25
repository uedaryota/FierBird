using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destry : MonoBehaviour
{
    void Start()
    {
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "EnemyDeath")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "名前")
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if(!GetComponent<Renderer>().isVisible)
        {
            Destroy(this.gameObject);
        }
    }
}
