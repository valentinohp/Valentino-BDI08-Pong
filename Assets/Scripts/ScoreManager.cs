using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int maxScore;
    public int leftScore;
    public int rightScore;
    public BallController ball;

    public void AddLeftScore()
    {
        leftScore++;
        ball.ResetBall();
        if (leftScore >= maxScore)
        {
            GameOver();
        }
    }

    public void AddRightScore()
    {
        rightScore++;
        ball.ResetBall();
        if (rightScore >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
