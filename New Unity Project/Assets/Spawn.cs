using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject asteroidLarge;
int enemies1count = 0;
int enemies2count = 0;
int enemies3count = 0;
int enemies4count = 0;

 float x;
 float y;
 float z;
 Vector3 pos;

     void Start () {

         enemies1count = 1;
         enemies2count = 1;
         enemies3count = 1;
         enemies4count = 1;
     }

    void Update()
    {
	GameObject[] enemies1 = GameObject.FindGameObjectsWithTag("asteroidLarge");
        enemies1count = enemies1.Length;
	GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("asteroid2");
        enemies2count = enemies2.Length;
	GameObject[] enemies3 = GameObject.FindGameObjectsWithTag("asteroid3");
        enemies3count = enemies3.Length;
	GameObject[] enemies4 = GameObject.FindGameObjectsWithTag("saucer");
        enemies4count = enemies4.Length;

        if(enemies1count == 0)
        {
	        if(enemies2count == 0)
        	{
		        if(enemies3count == 0)
		        {
			        if(enemies4count == 0)
			        {
//     x = Random.Range(-25, 26);
//     y = 5;
//     z = Random.Range(-25, 26);
//     pos = new Vector3(x, y, z);
//     transform.position = pos;
//  new Vector3((Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(1, 1)), "rotation"
//				        GameObject asteroidLargeClone = Instantiate(asteroidLarge, pos);
        			}

        		}

	        }

        }
    }
}
