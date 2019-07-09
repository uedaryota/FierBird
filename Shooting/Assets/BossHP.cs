using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHP : MonoBehaviour
{
    public readonly int maxHP = 100;
    public int HP = 100;
    public int PlayerATK = 1;
    void Start()
    {
        HP = maxHP;
    }
    
    void Update()
    {
        if(HP <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Ending");
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "PlayerBullet")
        {
            Debug.Log("hit");
            HP -= PlayerATK;
        }
    }
}
