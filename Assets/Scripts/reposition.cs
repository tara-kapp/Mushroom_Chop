using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class reposition : MonoBehaviour
{

    public Vector3 despawnPoint;
    public Vector3 spawnPoint;

    void Start()
    {
    }

    void Update()
    {
        if (transform.position.y < despawnPoint.y)
        {
            gameObject.transform.position = spawnPoint;
        }
    }
}
