using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HockeyManager : MonoBehaviour
{
    public int scorePlayer, scoreAI = 0;
    public ScoreText scoreTextPlayer, scoreTextAI;
    public DoubleTouch doubleTouch;

    public void OnScoreZoneReached(int id)
    {
        if (id == 1)
            scoreAI+=1;

        if (id == 2)
            scorePlayer+=1;

        UpdateScores();

       // doubleTouch.AICollisionCount = 0;
       // doubleTouch.playerCollisionCount = 0;

        if (scoreAI == 5)
        {
            SceneManager.LoadSceneAsync(4);   
        }
        else if (scorePlayer == 5)
        {
            SceneManager.LoadSceneAsync(3);
        }

    }

    public void UpdateScores()
    {
        scoreTextPlayer.SetScore(scorePlayer);
        scoreTextAI.SetScore(scoreAI);
    }

}
