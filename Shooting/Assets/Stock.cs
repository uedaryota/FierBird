using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stock : MonoBehaviour
{
    Text text;
    public int stock = 5;
    PlayerHealth health;
    public string st = "5";
    GameObject player;
    
    void Awake()
    {
        text = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player");
        health = player.GetComponent<PlayerHealth>();
    }
    void Update()
    {
        if (health.isRespon == true)
        {
            stock--;
        }
        switch(stock)
        {
            case 5:
                st = "5";
                Debug.Log("5");
                break;
            case 4:
                st = "4";
                Debug.Log("4");
                break;
            case 3:
                st = "3";
                Debug.Log("3");
                break;
            case 2:
                st = "2";
                Debug.Log("2");
                break;
            case 1:
                st = "1";
                Debug.Log("1");
                break;
            case 0:
                st = "0";
                Debug.Log("0");
                break;
        }
        text.text = "残りストック:" + st;
    }
}