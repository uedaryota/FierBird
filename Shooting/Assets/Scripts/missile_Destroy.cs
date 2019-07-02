using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile_Destroy : MonoBehaviour
{
    private float time;
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        time += Time.deltaTime;
        if(time>=3.0f)
        {
            Destroy(this.gameObject);
        }
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(this.gameObject);
        }
    }
}
