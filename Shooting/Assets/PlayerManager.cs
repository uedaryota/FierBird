using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    PlayerHealth health;
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        health = player.GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            player.transform.position = new Vector3(0f, 0.5f, 1.0f);
            player.SetActive(true);
        }
    }
}