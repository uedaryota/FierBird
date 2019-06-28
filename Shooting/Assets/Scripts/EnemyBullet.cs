using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 500;
    public int BulletInterval = 100;

    private int count = 0;

    //EnemyBulletプレハブ
    public GameObject enemyBullets;
    //弾丸発射点
    public Transform muzzle;

    void Update()
    {
        count += 1;

        //100フレーム事にEnemyShot()メソッドを実行
        if(count% BulletInterval == 0)
        {
            EnemyShot();
        }
    }

    public void EnemyShot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity)
            as GameObject;
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        //bulletRigidbody.AddForce(transform.forward * bulletSpeed);
        bulletRigidbody.AddForce(0, 0, -bulletSpeed);

        //弾丸の位置を調整
        enemyBullets.transform.position = muzzle.position;

    }

    public void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent<PlayerHealth>();
        if(health != null)
        {
            health.TakeDamage(10);
        }
    }
}
