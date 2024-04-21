using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class gameHandler : systemScoring
{
    public GameObject scoreText;
    //private int playerScore = 0;
    public GameObject[] hearts;
    public int health;
    public bool dead;

    void Start()
    {
        UpdateScore();
        health = 3;
    }

    public void UpdateLives(int health)
    {

        if (health < 1)
        {
            Destroy(hearts[0].gameObject);
            dead = true;
        }
        else if (health < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (health < 3)
        {
            Destroy(hearts[2].gameObject);
        }
        
    }

    private void Update()
    {
        UpdateScore();
        if (dead == true)
        {
            Debug.Log("You are dead! GAME OVER");
        }
    }

    /*public void AddScore(int points)
    {
        playerScore += points;
        UpdateScore();
    }

    public void MinusScore( int points)
    {
        playerScore -= points;
        UpdateScore();
    }*/

    void UpdateScore()
    {
        Text scoreTextB = scoreText.GetComponent<Text>();
        scoreTextB.text = "SCORE: " + score;
    }
}
