using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
	public GameObject bullet;
	public Transform ShotSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKeyDown(KeyCode.Space)) 
		{
			GameObject bulletClone = Instantiate (bullet, ShotSpawn.position, ShotSpawn.rotation);
			Destroy (bulletClone, 1);

		}
    }
}
