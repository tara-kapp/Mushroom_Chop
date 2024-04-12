using Leguar.LowHealth;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class systemScoring : MonoBehaviour
{
    public static int score;
    private static int health;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        health = 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       Debug.Log("Score: " +  score);
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
    }
}
