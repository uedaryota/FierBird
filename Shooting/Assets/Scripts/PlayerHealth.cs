using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    bool isDead;
    bool damaged;
    public int Heel = 20;
    //各コンポーネントを参照します。
    void Awake()
    {
        currentHealth = startingHealth;
    }
    //ダメージ受けたら赤く画面が光る
    void Update()
    {
        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            //赤く光ったのを元に戻します。
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed *
            Time.deltaTime);
        }
        damaged = false;
    }
    //ダメージを受ける関数
    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }
    void Death()
    {
        isDead = true;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "item")
        {
            if (currentHealth < 100)
            {
                currentHealth += Heel;
                healthSlider.value = currentHealth;
            }
        }
    }
}