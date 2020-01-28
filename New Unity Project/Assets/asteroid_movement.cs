using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid_movement : MonoBehaviour
{
    public float size;
    public float xval;
    public float zval;
    public GameObject asteroid;

    void Start()
    {
        xval = Random.Range(-1.0f, 2.0f);
        zval = Random.Range(-1.0f, 2.0f);
        if(xval == zval)
        {
            if (xval== 0.0f)
            {
                zval = zval + 0.1f;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Time.deltaTime * xval * size), 0, (Time.deltaTime * zval * size));
    }
}
