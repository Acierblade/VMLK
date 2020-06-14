﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class M_FPS_TEST : MonoBehaviour
{

    public Text text;
    public bool show = false;

    private const int targetFPS = 60;
    private const float updateInterval = 0.5f;

    private int framesCount;
    private float framesTime;

    void Start()
    {
        // no text object set? see if our gameobject has one to use
        if (text == null)
        {
            text = GetComponent<Text>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            show = !show;
        }

        // monitoring frame counter and the total time
        framesCount++;
        framesTime += Time.unscaledDeltaTime;

        // measuring interval ended, so calculate FPS and display on Text
        if (framesTime > updateInterval)
        {
            if (text != null)
            {
                if (show)
                {
                    float fps = framesCount / framesTime;
                    text.text = System.String.Format("{0:F2} FPS", fps);
                    text.color = (fps > (targetFPS - 5) ? Color.green :
                                 (fps > (targetFPS - 30) ? Color.yellow :
                                  Color.red));
                }
                else
                {
                    text.text = "";
                }
            }
            // reset for the next interval to measure
            framesCount = 0;
            framesTime = 0;
        }

    }
}

