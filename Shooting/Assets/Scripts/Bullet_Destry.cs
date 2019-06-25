using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destry : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
<<<<<<< HEAD:Shooting/Assets/Scripts/Bullet_Destry.cs
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Death" || col.gameObject.tag == "Player")
=======
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "EnemyDeath")
>>>>>>> 0578e96033a1fb6df06ece71c5d7b8503c28238b:Shooting/Assets/Bullet_Destry.cs
        {
            Destroy(gameObject);
        }
    }
}
