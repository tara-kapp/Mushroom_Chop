using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScore : MonoBehaviour
{
    public int highscore;
    public GameObject highscoretext;


    private void Start()
    {
        Text highscoretextb = highscoretext.GetComponent<Text>();
        highscore = LoadScore();
        highscoretextb.text = highscore.ToString();
    }


    int LoadScore()
    {
        return PlayerPrefs.GetInt("HighScore", 0);
    }
}
