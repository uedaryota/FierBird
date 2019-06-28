using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Move : MonoBehaviour
{
    private float pxv = 0f;//x軸移動量
    private float pzv = 0f;//z軸移動量

    public float speed = 8.0f;//移動スピード

    private Vector3 moveDirection = Vector3.zero;
    public static float px = 0;
    public static float pz = 0;
    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        pzv = 0f;
        pxv = 0f;
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        controller.Move(moveDirection * Time.deltaTime);
        Vector3 pos = transform.position;
        pos.x = pos.x+(pxv * speed);
        pos.z = pos.z + (pzv * speed);
    }
}
