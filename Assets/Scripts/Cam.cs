using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rot = Input.GetAxisRaw("Horizontal");  //¿Þ-1¿À+1

        if (rot == 1)
            transform.Rotate(Vector3.up * 90 * Time.deltaTime);
        else if(rot == -1)
            transform.Rotate(Vector3.down * 90 * Time.deltaTime);
    }
}
