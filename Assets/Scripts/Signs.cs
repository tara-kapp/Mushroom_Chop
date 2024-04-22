using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Signs : MonoBehaviour
{
    public Sprite[] signs;
    public float gameTimer = 0f;
    public int sign=0;
    public Image signHolder;

    void Start()
    {
        signHolder.sprite = signs[0];
    }

    void FixedUpdate()
    {
        SpawnSign();

    }


    void SpawnSign()
    {
        gameTimer += 0.01f;
        if (gameTimer >= 4)  { sign = 1; }
        if (gameTimer >= 8)  { sign = 2; }
        if (gameTimer >= 14) { sign = 3; }
        if (gameTimer >= 24) { sign = 4; }
        if (gameTimer >= 32) { sign = 5; }
        if (gameTimer >= 40) { sign = 6; }
        if (gameTimer >= 48) { sign = 7; }
        if (gameTimer >= 56) { sign = 8; }
        if (gameTimer >= 64) { sign = 9; }
        if (gameTimer >= 72) { sign = 10;}
        signHolder.sprite = signs[sign];

        Debug.Log(signs[sign]);
    }
}
