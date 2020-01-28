using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

	public Text ScoreText;
	public int score;

    void Start()
    {
	score = 0;
    }

            public void addScoreOne()
    {
		score += 20;
		ScoreText.text = "Points: " + score;
    }
            public void addScoreTwo()
    {
		score += 50;
		ScoreText.text = "Points: " + score;
    }
            public void addScoreThree()
    {
		score += 100;
		ScoreText.text = "Points: " + score;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
