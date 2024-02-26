using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D BirdRigidBody;
    public Animator FlyAnimation;
    public int BirdVelocity = 5;
    private bool IsFlying = false;
    public GameStatus GameState;
    private bool GameEnded = false;
    public GameObject GameOverScreen;

    // Update is called once per frame
    void Update()
    {
        if (GameState.GameOver)
        {
            if ( ! GameEnded )
                GameOverScreen.SetActive(true);
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space) && ! IsFlying)
        {
            IsFlying = true;
            BirdRigidBody.velocity = Vector2.up * this.BirdVelocity;
        } else if (IsFlying)
            IsFlying = false;
        FlyAnimation.SetBool("fly", IsFlying);
        if (transform.position.y >= 6 || transform.position.y <= -6)
            GameState.GameOver = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameState.GameOver = true;
    }
}
