using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : MonoBehaviour
{

    private float rad;
    public GameObject Enemy;
    public Vector3 speed = new Vector3(0.05f, 0f, 0.05f);

    private Vector3 Position;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject Enemy = GameObject.FindGameObjectWithTag("Enemy");
        float speed = 1.0f;
        float step = Time.deltaTime * speed*15;
        transform.position = Vector3.MoveTowards(transform.position, Enemy.transform.position, step);
    }
}
