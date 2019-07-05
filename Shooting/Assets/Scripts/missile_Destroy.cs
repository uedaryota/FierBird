using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile_Destroy : MonoBehaviour
{
    private float time;
    void OnCollisionEnter(Collision col)
    {
<<<<<<< HEAD
        if(col.gameObject.tag == "Enemy"||col.gameObject.tag=="Wall")
=======
        if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "Wall")
>>>>>>> 34ba8da1dc923550351ebfec5e80d021aae33374
        {
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        Transform mytransform = this.transform;
        Vector3 pos = mytransform.position;
        if(pos.y>=2)
        {
            Destroy(this.gameObject);
        }
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
