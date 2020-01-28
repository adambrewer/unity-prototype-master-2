using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerShootShot : MonoBehaviour
{

	public GameObject SaucerShot;
	public Transform SaucerSpawn;
public float Timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
             Timer -= Time.deltaTime;
     if (Timer <= 0f)
     {
         GameObject SaucerShotClone = Instantiate (SaucerShot, SaucerSpawn.position, SaucerSpawn.rotation);;
			Destroy (SaucerShotClone, 0.5f);
         Timer = 2f;
     }
    }
}
