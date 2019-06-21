using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destry : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Death" || col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
