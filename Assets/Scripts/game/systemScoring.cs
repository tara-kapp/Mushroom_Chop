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

    void Start()
    {
        UpdateScore();
        score = 0;
        health = 3;      
    }

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

    public void AddScore()
    {
        score++;        
    }
    
    public void RemoveScore()
    {
        score--;        
    }

    public void RemoveHealth()
    {
        health--;        
        
        if (health < 1)
        {            
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

    void SaveScore()
    {
        Debug.Log(score);
        PlayerPrefs.SetInt("HighScore", score);
        //PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();
    }
}
