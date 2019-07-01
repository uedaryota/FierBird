﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject playerPrefab;
    PlayerHealth health;
    
    void Start()
    {
        health = GetComponent<PlayerHealth>();
    }
    
    void Update()
    {
        if (health.Death == true)
        {
            Instantiate(playerPrefab, new Vector3(0.0f, 0.5f, 1.0f), Quaternion.identity);
        }
    }
}