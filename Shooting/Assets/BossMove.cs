using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public GameObject boss0_bullet_prefab;//弾prefabタブ表示
    public GameObject explosion_prefab;//爆破prefabタブ表示
    private int boss_t;//ボス体力
    private int shot_time;//生存、発射時間
    private int wayNumber;

    // Start is called before the first frame update
    void Start()
    {
        boss_t = 100;
        shot_time = 0;//生存、発車時間初期設定
        
        for (int i=0; i<wayNumber;i++)
        {
            GameObject enemyFireMissile = (GameObject)Instantiate(boss0_bullet_prefab, transform.position, Quaternion.Euler(0, -30 + (15 * i), 0));
            enemyFireMissile.transform.SetParent(this.gameObject.transform);
        }
    }


    void OnCollisionEnter(Collision col)//当たり判定
    {
        if (col.gameObject.tag=="Player")
        {
            Destroy(col.gameObject);//自機弾削除
            boss_t -= 1;
            if(boss_t<=0)
            {
                Destroy(gameObject);//ボス削除
                for(int i=0; i<50;i++)
                {
                    Instantiate(explosion_prefab, new Vector3(-4f + 8f * Random.value, 0f + 4f * Random.value, 0)
                        , Quaternion.identity);//爆破表示
                }
            }
        }
    }
}
