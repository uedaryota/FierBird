using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    private int frame = 0;
    private float time = 0.0f;
    
    public bool isRespon = false;
    private Vector3 initPos;
    public int playerstock = 5;

    void Start()
    {
        initPos = new Vector3(0f, 0.5f, 1.0f);
    }

    void Update()
    {
        if(isRespon == true)
        {
            Debug.Log("true");
            if(Input.GetButtonDown("Jump"))
            {
                gameObject.SetActive(true);
                gameObject.transform.position = initPos;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(playerstock < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "EnemyBulle")
        {
            playerstock--;
            gameObject.SetActive(false);
        }
    }



    //α版用
    /*public bool Death = false;

    public void Start()
    {
        Death = false;
    }

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "EnemyBulle")
        {
            Death = true;
            Destroy(gameObject);
            //SceneManager.LoadScene("GameOver");
        }
        Death = false;
    }*/
}