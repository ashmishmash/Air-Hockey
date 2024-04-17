using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Reset : MonoBehaviour
{
    public GameObject whiteBall;
    public GameObject AIPuck;
    public GameObject playerPuck;

    public HockeyManager hockeyManager;
    public Vector3 PlayerPosition = new Vector3(9.64f, -1.089f, 0f);
    public Vector3 AIPosition = new Vector3(-11.96f, -0.93f, 0f);
    public Vector3 BallPosition = new Vector3(-1.25f, -1.14f, 0f);

    private void Start()
    {
        ResetWhiteBall();
        ResetAIPuck();
        ResetPlayerPuck();
        ResetScores();
    }
    public void ResetWhiteBall()
    {
        whiteBall.transform.position = BallPosition;
    }

    public void ResetAIPuck()
    {
        AIPuck.transform.position = AIPosition;
    }

    public void ResetPlayerPuck()
    {
        playerPuck.transform.position = PlayerPosition;
    }

    public void ResetScores()
    {
        hockeyManager.scoreAI = 0;
        hockeyManager.scorePlayer = 0;

        hockeyManager.scoreTextPlayer.SetScore(hockeyManager.scorePlayer);
        hockeyManager.scoreTextAI.SetScore(hockeyManager.scoreAI);
    }

}
