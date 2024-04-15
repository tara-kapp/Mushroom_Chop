using Leguar.LowHealth;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class systemScoring : MonoBehaviour
{
    public static int score;
    private static int health;

    // allows access to gamehandler script
    public gameHandler gameHandlerObj;

 
    void Start()
    {
        score = 0;
        health = 3;

        
        if (GameObject.FindWithTag("GameHandler") != null)
        {
            gameHandlerObj = GameObject.FindWithTag("GameHandler").GetComponent<gameHandler>();
        }
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
       Debug.Log("Score: " +  score);
    }

    public void AddScore()
    {
        score++;
        gameHandlerObj.AddScore(1);     // addscore from gamehandler script
    }
    
    public void RemoveScore()
    {
        score--;
        gameHandlerObj.MinusScore(1);
    }

    public void RemoveHealth()
    {
        health--;

        gameHandlerObj.UpdateLives(health);
        
    }
}
