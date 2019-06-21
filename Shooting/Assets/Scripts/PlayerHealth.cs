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
    public AudioClip deathClip;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    Animator anim;
    AudioSource playerAudio;
    //PlayerMovement playerMovement;
    //PlayerShooting playerShooting;
    bool isDead;
    bool damaged;
    public int Heel = 20;
    //各コンポーネントを参照します。
    void Awake()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        //playerMovement = GetComponent<PlayerMovement>();
        //playerShooting = GetComponentInChildren<PlayerShooting>();
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
        playerAudio.Play();
        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }
    void Death()
    {
        isDead = true;
        //playerShooting.DisableEffects();
        anim.SetTrigger("Die");
        playerAudio.clip = deathClip;
        playerAudio.Play();
        //playerMovement.enabled = false;
        //playerShooting.enabled = false;
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