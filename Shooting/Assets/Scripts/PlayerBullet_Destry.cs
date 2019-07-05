using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet_Destry : MonoBehaviour
{
    void Start()
    {
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "PlayerDeath" || col.gameObject.tag == "Wall")

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
