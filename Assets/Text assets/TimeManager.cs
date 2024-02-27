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
    public GameStatus GameState;

    // Update is called once per frame
    void Update()
    {
        if (GameState.GameOver)
            return;
        timer += Time.deltaTime;
        GameTimer = Convert.ToInt32(Math.Floor(timer));
        GameState.GameTime = GameTimer;
        TimeDisplayed.text = GameTimer.ToString();
    }
}
