using Leguar.LowHealth;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class systemScoring : MonoBehaviour
{
    public static int score;
    public static int health;
    public GameObject[] hearts;
    public bool dead;
    public GameObject scoreText;


    // allows access to gamehandler script
    //public gameHandler gameHandlerObj;


    void Start()
    {
        UpdateScore();
        score = 0;
        health = 3;      
    }

    /*public void UpdateLives()
    {
        if (health < 1)
        {
            Debug.Log(health);
            Destroy(hearts[0].gameObject);
            dead = true;
            SceneManager.LoadSceneAsync("GameOver");
        }
        else if (health < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (health < 3)
        {
            Destroy(hearts[2].gameObject);
        }        
    }*/

    void Update()
    {
        UpdateScore();
        
        if (dead == true)
        {
            Debug.Log("True");
            SaveScore();
            SceneManager.LoadSceneAsync("GameOver");            
        }
    }

    void UpdateScore()
    {
        Text scoreTextB = scoreText.GetComponent<Text>();
        scoreTextB.text = "SCORE: " + score;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
       //Debug.Log("Score: " +  score);
    }

    public void AddScore()
    {
        score++;
        //gameHandlerObj.AddScore(1);     // addscore from gamehandler script
    }
    
    public void RemoveScore()
    {
        score--;
        //gameHandlerObj.MinusScore(1);
    }

    public void RemoveHealth()
    {
        health--;
        //UpdateLives();
        
        if (health < 1)
        {
            Debug.Log(health);
            Destroy(hearts[0].gameObject);
            SaveScore();
            SceneManager.LoadSceneAsync("GameOver");
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


    // Save the score
    void SaveScore()
    {
        PlayerPrefs.SetInt("HighScore", score);
        //PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();
    }

    int LoadScore()
    {
        return PlayerPrefs.GetInt("HighScore", 0);
    }
    string LoadPlayerName()
    {
        return PlayerPrefs.GetString("PlayerName", "Player");
    }
}
