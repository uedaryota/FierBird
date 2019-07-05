using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private int frame = 0;
    private float time = 0.0f;

    //対象のオブジェクト
    public GameObject desObj;
    public bool isRespon = false;
    private Vector3 initPos;
    public int playerstock = 5;

    void Start()
    {
        this.initPos = Vector3.zero;
        desObj = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if(isRespon)
        {
            time += Time.deltaTime;
            if(time >= 3.0f)
            {
                time = 0.0f;
                isRespon = false;
                this.desObj.SetActive(true);
                this.desObj.transform.position = initPos;
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
            this.desObj.SetActive(false);
            isRespon = true;
        }
    }

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
<<<<<<< HEAD
            SceneManager.LoadScene("GameOver");
=======
            //SceneManager.LoadScene("GameOver");
>>>>>>> 34ba8da1dc923550351ebfec5e80d021aae33374
        }
        Death = false;
    }*/
}