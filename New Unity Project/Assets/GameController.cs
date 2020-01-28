using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public GameObject[] hazards;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	public Text ScoreText;
	public int score;


//	private bool gameOverMan;
//	private bool restart;


    void Start()
    {
//		gameOverMan = false;
//		restart = false;
		score = 0;
    }

	void Update()
	{
		UpdateScore();
		
		if (Input.GetKey("escape"))
		{
			Application.Quit();
		}

//		if (restart)
//		{
//			if (Input.GetKeyDown(KeyCode.T))
//			{
//				SceneManager.LoadScene("SampleScene");
//			}
//		}
//		
//		if (hazardCount == 0){
//			for(int i = 0; i < hazardCount; i++)
//			{
//				GameObject asteroidLarge = hazards[Random.Range (0, hazards.Length)];
//				Vector3 spawnPosition = new Vector3(Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
//				Quaternion spawnRotation = Quaternion.identity;
//				Instantiate (asteroidLarge, spawnPosition, spawnRotation);
//			}
//
//			if (gameOverMan)
//			{
//				restart = true;
//			}
//		}

	}
	
	void UpdateScore()
	{
		ScoreText.text = "Points: " + score;
	}

	public void AddScore(int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore();
	}	



	
}

