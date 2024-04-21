using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class edible : MonoBehaviour
{
    public Boolean is_edible;
    public Boolean trip;

    public void SetEdible(GameObject mushroom)
    {
        is_edible = true;
    }

    public void SetInEdible(GameObject mushroom)
    {
        is_edible = false;
    }

    public void SetHallucinate(GameObject mushroom)
    {
        trip = true;
    }

    public Boolean GetEdible(GameObject mushroom)
    {
        return is_edible;
    }

    public Boolean GetHallucinate(GameObject mushroom)
    {
        return trip;
    }
}
