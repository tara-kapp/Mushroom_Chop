using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guide : MonoBehaviour
{
    public Sprite[] guides;
    public Image guideUI;
    public int guideNum;
    
    // Start is called before the first frame update
    void Start()
    {
        guideNum = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        guideUI.sprite = guides[guideNum];
    }

    public void LeftOnClick()
    {
        if (guideNum < guides.Length - 1) { guideNum++; }
    }

    public void RightOnClick()
    {
        if( guideNum > 0) { guideNum--; }
    }
}
