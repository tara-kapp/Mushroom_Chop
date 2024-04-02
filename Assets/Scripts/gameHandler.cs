using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameHandler : MonoBehaviour
{
    // Use this script to control point system

    // 
    public GameObject scoreText;
    private int playerScore = 0;

    void Start()
    {
        UpdateScore();
    }
    public void AddScore(int points)
    {
        playerScore += points;
        UpdateScore();
    }

    void UpdateScore()
    {
        Text scoreTextB = scoreText.GetComponent<Text>();
        scoreTextB.text = "SCORE: " + playerScore;
    }

}
