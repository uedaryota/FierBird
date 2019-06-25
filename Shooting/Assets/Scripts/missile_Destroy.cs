using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile_Destroy : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
