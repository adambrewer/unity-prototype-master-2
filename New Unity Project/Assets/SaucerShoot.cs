using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerShoot : MonoBehaviour
{

	int speed = 10;
	GameObject player = GameObject.FindGameObjectWithTag("Player");
	Vector3 lastPos;


    void Start()
    {

       lastPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);

    }
 
    void Update()
    {
     transform.position = Vector3.MoveTowards(transform.position, lastPos, speed * Time.deltaTime);
      lastPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
    }
}
