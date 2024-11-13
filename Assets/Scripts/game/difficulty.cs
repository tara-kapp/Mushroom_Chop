using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficulty : MonoBehaviour
{
    public static string gameDifficulty;
    public void easyButton()
    {
        Debug.Log("difficulty set to easy");
        PlayerPrefs.SetString("gameDifficulty", "easy");
        PlayerPrefs.Save();
    }
    public void normalButton()
    {
        Debug.Log("difficulty set to normal");
        PlayerPrefs.SetString("gameDifficulty", "normal");
        PlayerPrefs.Save();
    }
    public void hardButton()
    {
        Debug.Log("difficulty set to hard");
        PlayerPrefs.SetString("gameDifficulty", "hard");
        PlayerPrefs.Save();
    }
}
