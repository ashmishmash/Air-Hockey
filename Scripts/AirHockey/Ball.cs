using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions.Must;

public class Ball : MonoBehaviour
{
    public HockeyManager hockeyManager;
    public GameObject playerPuck;
    public GameObject AIPuck;
    public Reset reset;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {

        ScoreZone scoreZone = collision.GetComponent<ScoreZone>();

        if (scoreZone)
        {
            hockeyManager.OnScoreZoneReached(scoreZone.id);
            ResetBall();
            ResetAIPuck();
           
       }
    
    }

   public void ResetBall()
    { 
      Vector2 position = new Vector2(-1.2f, -1f);
       transform.position = position;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }


    public void ResetAIPuck()
    {
        Vector3 newPosition = new Vector3(-12.17f, -1.13f, 0f);
        AIPuck.transform.position = newPosition;
    }


 }
