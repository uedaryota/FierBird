using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public readonly int maxHP = 100;
    public int HP = 100;
    public int PlayerATK = 10;

    void Start()
    {
        HP = maxHP;
    }

    void Update()
    {
        if(HP <= 0)
        {
            FindObjectOfType<Score>().AddPoint(100);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "PlayerBullet")
        {
            HP -= PlayerATK;
        }
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "EnemyDeath")
        {
            Destroy(gameObject);
        }
    }
}
