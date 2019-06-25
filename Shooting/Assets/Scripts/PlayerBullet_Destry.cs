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
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "PlayerDeath")
        {
            Destroy(gameObject);
        }
<<<<<<< HEAD:Shooting/Assets/Bullet_Destry.cs
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
=======
>>>>>>> f442178f1a85eccb661a9eb195feb56a7a1c37b9:Shooting/Assets/Scripts/PlayerBullet_Destry.cs
    }
}
