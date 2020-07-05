﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public float countdown = 25.0f;
    public Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        timeText.text = countdown.ToString("f1") + "秒";

        if (countdown <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }
}

