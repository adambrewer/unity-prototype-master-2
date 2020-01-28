using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saucer_Movement : MonoBehaviour
{
    public int xdirection;
    public int zdirection;
    public GameObject saucer;
    public int size;
    public int counter;
    public int counterlimit;
    
    void Start()
    {
        xdirection = Random.Range(-1, 2);
        zdirection = 0;
        counterlimit = Random.Range(30, 90);
        counter = 0;
    }


    // Update is called once per frame
    void Update()
    {
            if (counter <= counterlimit)
            {
                transform.Translate((Time.deltaTime * xdirection * size), 0, (Time.deltaTime * zdirection * size));
                counter++;
            }
            else
            {
                if (zdirection == 0)
               {
                zdirection = Random.Range(-1, 2);
                counter = 0;
                transform.Translate((Time.deltaTime * xdirection * size), 0, (Time.deltaTime * zdirection * size));
                counterlimit = Random.Range(30, 90);
            }
                else
                {
                    zdirection = 0;
                    counter = 0;
                    transform.Translate((Time.deltaTime * xdirection * size), 0, (Time.deltaTime * zdirection * size));
                counterlimit = Random.Range(30, 90);
            }
            }   
    }
}
