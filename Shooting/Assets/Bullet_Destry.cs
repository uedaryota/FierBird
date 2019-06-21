using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destry : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "名前")
        {
            Destroy(gameObject);
        }

    }
}
