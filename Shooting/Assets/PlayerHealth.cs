using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private Vector3 initPos;
    public int playerstock = 5;

    void Start()
    {
        initPos = new Vector3(0f, 0.5f, 1.0f);
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            gameObject.SetActive(true);
            gameObject.transform.position = initPos;
        }
        if(playerstock < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "EnemyBulle")
        {
            playerstock--;
            gameObject.SetActive(false);
        }
    }
}