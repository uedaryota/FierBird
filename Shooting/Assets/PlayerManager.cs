using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject playerPrefab;
    PlayerHealth health;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health.Death == true)
        {
            Instantiate(playerPrefab, new Vector3(0.0f, 0.5f, 1.0f), Quaternion.identity);
        }
    }
}
