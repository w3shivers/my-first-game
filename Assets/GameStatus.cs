using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    private static bool IsGameOver = false;
    private static bool IsPaused = true;
    private static int FlySeconds = 0;

    public bool GameOver
    {
        get
        {
            return IsGameOver;
        }
        set
        {
            IsGameOver = value;
        }
    }

    public bool GamePaused
    {
        get
        {
            return IsPaused;
        }
        private set { IsPaused = value; }
    }

    public int GameTime
    {
        get { return FlySeconds; }
        set { FlySeconds = value; }
    }

    public void PauseGame()
    {
        GamePaused = true;
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        GamePaused = false;
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        GameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
