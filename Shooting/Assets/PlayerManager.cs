using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            player.transform.position = new Vector3(0f, 0.5f, 1.0f);
            player.SetActive(true);
        }
    }
}