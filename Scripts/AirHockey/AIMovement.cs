using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{

    public GameObject ball;
    Rigidbody2D rb;
    public GameObject goalPosition;


    public float speed = 20f;
    private float increasedSpeed = 15f;
    private float speedIncreaseRange = 3f;
    //private float detectionRange = 0.0001f;

    private bool canHitBall = true;
    int hitCount;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hitCount = 0;

    }

    void FixedUpdate()
    {
        Vector3 directionToBall = ball.transform.position - transform.position; //ai to ball
        Vector3 goalPosition = new Vector3(29.1f, -5.7838f, 0f);
        Vector3 ballPosition = new Vector3(ball.transform.position.x, ball.transform.position.y, ball.transform.position.z);
        Vector3 directionToGoal = goalPosition - ballPosition;

        float currentMovementSpeed = Mathf.Abs(transform.position.x) <= speedIncreaseRange ? increasedSpeed : speed;

        rb.AddForce(directionToBall.normalized * currentMovementSpeed);

        if (canHitBall && hitCount ==1)
        {
            if (goalPosition.x < ball.transform.position.x && ball.transform.position.x < transform.position.x)
            {
                HitBall(directionToGoal.normalized);
            }
            else
            {
                HitBall(directionToBall.normalized);
            }
        } 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            hitCount += 1;
        }
    }

    void HitBall(Vector3 hitDirection)
    {
        Rigidbody2D ballrb = ball.GetComponent<Rigidbody2D>();

        ballrb.AddForce(hitDirection * speed, ForceMode2D.Impulse);

        canHitBall = false;
        hitCount = 0;
        Invoke("ResetHitBallFlag", 2f);
    }

    void ResetHitBallFlag()
    {
        canHitBall = true;
    }

   

}
