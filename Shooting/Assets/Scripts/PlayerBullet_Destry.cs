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
<<<<<<< HEAD
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "PlayerDeath"||col.gameObject.tag=="Wall")
=======
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "PlayerDeath" || col.gameObject.tag == "Wall")
>>>>>>> 34ba8da1dc923550351ebfec5e80d021aae33374
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
