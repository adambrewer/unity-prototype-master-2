using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyperspace : MonoBehaviour
{
    public GameObject ship;
    public float minZ;
    public float maxZ;
    public float minX;
    public float maxX;
    public float randomX;
    public float randomZ;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            randomX = Random.Range(minX, maxX);
            randomZ = Random.Range(minZ, maxZ);
            ship.transform.position = new Vector3(randomX, 0, randomZ);
        }
    }
}
