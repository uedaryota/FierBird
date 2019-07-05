using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]
    //ポーズした時に表示するUIのプレハブ
    private GameObject pauseUIPrefab;
    //ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    void Update()
    {
        if(Input.GetKeyDown("q"))
        {
            if(pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0.0f;
            }
            else
            {
                Destroy(pauseUIInstance);
                Time.timeScale = 1.0f;
            }
        }
    }
}
