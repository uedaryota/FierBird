using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBallet : MonoBehaviour
{
    public GameObject bossBallet;
    public float BalletSpeed;
    public AudioClip BalletSound;
    
    private int timeCount;//発射間隔

    void Update()
    {
        timeCount += 1;

        if (timeCount % 10 == 0)
        {
            GameObject Ballet = Instantiate(bossBallet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody missileRb = Ballet.GetComponent<Rigidbody>();
            missileRb.AddForce(transform.forward * BalletSpeed);
            //AudioSource.PlayClipAtPoint(BalletSound, transform.position);
            Destroy(Ballet, 2.0f);
        }
    }
}
