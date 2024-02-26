using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    private bool IsGameOver = false;
    public bool GameOver
    {
        get
        {
            return this.IsGameOver;
        }
        set
        {
            this.IsGameOver = value;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
