using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed;

    private int count = 0;

  
    void Update()
    {
        count += 1;

        //100フレーム事にEnemyShot()メソッドを実行
        if(count%100==0)
        {
            EnemyShot();
        }
    }

    public void EnemyShot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity)
            as GameObject;
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        bulletRigidbody.AddForce(transform.forward * bulletSpeed);

        Destroy(bullet, 1.5f);
    }
}
