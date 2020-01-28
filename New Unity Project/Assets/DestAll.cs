using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestAll : MonoBehaviour
{

public int lives;
public Text LivesText;
public Text GameOver;
public Text Restart;

    // Start is called before the first frame update
    void Start()
    {
	lives = 3;        
	LivesText.text = "Lives: 3";
	GameOver.text = "";
	Restart.text = "";
    }

    void OnTriggerEnter(Collider other)
	{
	if (other.tag != "bullet")
	{
        	Destroy(other.gameObject);
		lives -= 1;
		LivesText.text = "Lives: " + lives;
		if (lives == 0)
		{
	        	Destroy(gameObject);
			GameOver.text = "Game Over";
			Restart.text = "Press R to Restart";
		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene("Level2");
		}

		}
	}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
