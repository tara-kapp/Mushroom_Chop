using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine;

public class randomMush : MonoBehaviour
{
    public GameObject mushroom1;
    public GameObject mushroom2;

    void Start()
    {
        mushroomSwitch( mushroom1, mushroom2 );
    }

    // Update is called once per frame
    public GameObject mushroomSwitch(GameObject mush1, GameObject mush2)
    {
        int num = UnityEngine.Random.Range(0, 2);
        if (num == 0) { return mush1; }
        else { return mush2; }
    }
}
