using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet_Destry : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "EnemyDeath")
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
