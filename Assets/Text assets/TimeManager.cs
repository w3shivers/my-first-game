using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public int GameTimer = 0;
    public Text TimeDisplayed;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        GameTimer = Convert.ToInt32(Math.Floor(timer));
        TimeDisplayed.text = GameTimer.ToString();
    }
}
