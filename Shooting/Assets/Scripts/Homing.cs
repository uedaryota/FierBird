using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : MonoBehaviour
{

    private float rad;
    public GameObject Enemy;
    public Vector3 speed = new Vector3(0.05f, 0f, 0.05f);
    private float time;
    private Vector3 Position;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject Enemy = GameObject.FindGameObjectWithTag("Enemy");
        time += Time.deltaTime;
        float speed = 1.0f;
        float step = Time.deltaTime * speed * 10;
        transform.position = Vector3.MoveTowards(transform.position, Enemy.transform.position, step);
        if (time>1.0f)
        {
            float changespeed = 1;
            Vector3 velocity = gameObject.transform.rotation * new Vector3(changespeed, 0, 0);
            gameObject.transform.position += velocity * Time.deltaTime;

        }
    }
}
