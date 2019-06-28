using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public const int maxHealth = 50;
    public int currentHealth = maxHealth;
    public RectTransform healthBar;

    //無敵時間
    //private const float Invincible_Time = 1.0f;
    //private float _invincibleTime;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            Destroy(gameObject);
        }
        healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);

        //gameObject.layer = LayerName.PlayerInvicibleLayer;
        //_invincibleTime = Invincible_Time;
    }

    //public void Update()
    //{
    //    if(_invincibleTime > 0)
    //    {
    //        _invincibleTime -= Time.deltaTime;
    //        if(_invincibleTime <= 0)
    //        {
    //            gameObject.layer = LayerName.PlayerNomalLayer;
    //        }
    //    }
    //}
}