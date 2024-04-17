using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTouch : MonoBehaviour
{
    public int playerCollisionCount = 0;
    public int AICollisionCount = 0;

    public HockeyManager hockeyManager;

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            playerCollisionCount++;

            if (playerCollisionCount == 2)
            {
                if (hockeyManager.scorePlayer > 0)
                {
                    hockeyManager.scorePlayer -= 1;
                    hockeyManager.UpdateScores();
                }
                playerCollisionCount = 0;
                
            }

        }

        if (collision.gameObject.tag == "AI")
        {
            AICollisionCount++;

            if (AICollisionCount == 2)
            {
                if (hockeyManager.scoreAI > 0)
                {
                    hockeyManager.scoreAI -= 1;
                    hockeyManager.UpdateScores();
                }
                AICollisionCount = 0;
            }

        }
    }
}
