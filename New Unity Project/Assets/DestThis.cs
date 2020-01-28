using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestThis : MonoBehaviour
{
	public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
    }
    void OnTriggerEnter(Collider other)
	{
	if (other.tag == "bullet")
	{
		gameController.AddScore (100);
        	Destroy(other.gameObject);
        	Destroy(gameObject);
	}
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
