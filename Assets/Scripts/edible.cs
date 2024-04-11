using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class edible : MonoBehaviour
{
    public Boolean is_edible;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        is_edible = true;
    }
}
