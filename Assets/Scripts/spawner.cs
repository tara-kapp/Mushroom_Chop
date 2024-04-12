using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public int mush;
    public int mushCount = 4;
    public Transform[] spawnPoints;
    public int rangeEnd;
    private Transform spawnPoint;
    public GameObject timeText;
    
    public GameObject[] mushrooms;

    public float gameTimer = 0f;

    //spawn delay
    public float delay = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rangeEnd = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mush = UnityEngine.Random.Range(0, rangeEnd);
        delay += 1;
        if (delay % 50 == 0)
        {
            spawnMushroom();
        }
        if( delay >= 100)
        {
            delay = 0;
        }

        gameTimer += 0.01f;
        if ( gameTimer >= 2)
        {
            rangeEnd = 2;
        }
        if ( gameTimer >= 4)
        {
            rangeEnd = 3;
        }
        if (gameTimer >= 8)
        {
            rangeEnd = 4;
        }
        if (gameTimer >= 16)
        {
            rangeEnd = 5;
        }
        if (gameTimer >= 32)
        {
            rangeEnd = 6;
        }
        if (gameTimer >= 64)
        {
            rangeEnd = 7;
        }
        if (gameTimer >= 76)
        {
            rangeEnd = 8;
        }
        if (gameTimer >= 88)
        {
            rangeEnd = 9;
        }
        if (gameTimer >= 100)
        {
            rangeEnd = 10;
        }
        if (gameTimer >= 120)
        {
            rangeEnd = 11;
        }
    }

    void spawnMushroom()
    {
        int SPnum = UnityEngine.Random.Range(0, 11);
        spawnPoint = spawnPoints[SPnum];

        Instantiate( mushrooms[mush], spawnPoint.position, Quaternion.identity);
    }
}
