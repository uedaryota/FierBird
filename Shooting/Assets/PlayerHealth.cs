using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public bool Death = false;

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
            SceneManager.LoadScene("GameOver");
        }
        Death = false;
    }
}