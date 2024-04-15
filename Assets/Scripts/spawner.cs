using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class spawner : MonoBehaviour
{
    //Spawnpoint variables
    public Transform[] spawnPoints;
    private Transform spawnPoint;
    //mushroom object arrays
    public GameObject[] mushrooms;
    public GameObject[] otherSprites;
    //variable to find mushroom
    public int mush;
    //variable to determine number of mushroom types
    public int rangeEnd;
    
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
        //Pick Random Mushroom type to spawn within range
        mush = UnityEngine.Random.Range(0, rangeEnd);
        //mushroom spawn frequency
        delay += 1;
        if (delay % 50 == 0) { spawnMushroom(); }
        if( delay >= 100) { delay = 0; }

        //Game Timer + Variety Increase
        gameTimer += 0.01f;
        if ( gameTimer >= 2)  { rangeEnd = 2;  }
        if ( gameTimer >= 4)  { rangeEnd = 3;  }
        if (gameTimer >= 8)   { rangeEnd = 4;  }
        if (gameTimer >= 16)  { rangeEnd = 5;  }
        if (gameTimer >= 32)  { rangeEnd = 6;  }
        if (gameTimer >= 64)  { rangeEnd = 7;  }
        if (gameTimer >= 76)  { rangeEnd = 8;  }
        if (gameTimer >= 88)  { rangeEnd = 9;  }
        if (gameTimer >= 100) { rangeEnd = 10; }
        if (gameTimer >= 120) { rangeEnd = 11; }
    }

    void spawnMushroom()
    {
        int SPnum = UnityEngine.Random.Range(0, 11);
        spawnPoint = spawnPoints[SPnum];

        if ( mush == 6 ) spriteSwitch(otherSprites[0], otherSprites[1]); //inky cap
        else if (mush == 3) spriteSwitch(otherSprites[2], otherSprites[3]); //fly agaric
        else if (mush == 5) spriteSwitch(otherSprites[4], otherSprites[5]); //rosy veincap
        else if (mush == 7) spriteSwitch(otherSprites[6], otherSprites[7]); //chanterelle
        else Instantiate(mushrooms[mush], spawnPoint.position, Quaternion.identity); 
    }

    public void spriteSwitch(GameObject mush1, GameObject mush2)
    {
        int num = UnityEngine.Random.Range(0, 2);
        if (num == 0) { Instantiate(mush1, spawnPoint.position, Quaternion.identity); }
        else { Instantiate(mush2, spawnPoint.position, Quaternion.identity); }
    }
}
