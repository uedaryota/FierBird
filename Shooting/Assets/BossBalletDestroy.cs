using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBalletDestroy : MonoBehaviour
{
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        GameObject wall = GameObject.FindGameObjectWithTag("Wall");
    }
    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
