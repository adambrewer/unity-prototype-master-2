using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BreakIt : MonoBehaviour
{

	public GameObject asteroidLarge;
	public GameObject asteroid2;
	public GameObject asteroid3;

	public Transform asteroidLargePos;
	public Transform asteroid2Pos;

//	public Text ScoreText;
//	public int score;

//	public int scoreValue;
	public GameController gameController;

//	GameObject scorecount;

	void Start ()
	{
//	score = 0;
//	scorecount = GameObject.Find("ScoreCounter");

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
	if (other.tag == "asteroidLarge")
	{
//	scoreCount.addScoreOne();
//		score += 20;
//		ScoreText.text = "Points: " + score;
	gameController.AddScore (20);
	GameObject asteroid2Clone1 = Instantiate (asteroid2, asteroidLargePos.position, asteroidLargePos.rotation);
	GameObject asteroid2Clone2 = Instantiate (asteroid2, asteroidLargePos.position, asteroidLargePos.rotation);
        	Destroy(other.gameObject);
        	Destroy(gameObject);
	}
	if (other.tag == "asteroid2")
	{
//	ScoreCounter.addScoreTwo();
//		score += 50;
//		ScoreText.text = "Points: " + score;
	gameController.AddScore (50);
	GameObject asteroid3Clone1 = Instantiate (asteroid3, asteroid2Pos.position, asteroid2Pos.rotation);
	GameObject asteroid3Clone2 = Instantiate (asteroid3, asteroid2Pos.position, asteroid2Pos.rotation);
        	Destroy(other.gameObject);
        	Destroy(gameObject);
	}
	if (other.tag == "asteroid3")
	{
//	ScoreCounter.addScoreThree();
//		score += 100;
//		ScoreText.text = "Points: " + score;
	gameController.AddScore (100);
        	Destroy(other.gameObject);
        	Destroy(gameObject);
	}
	if (other.tag == "player")
	{		
	}

    }

}