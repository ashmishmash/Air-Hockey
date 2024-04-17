using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITrigger : MonoBehaviour
{
    public GameObject whiteBall;
    Rigidbody2D rb;
    public GameObject goalPos;

public float puckSpeed = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 goalPosition = new Vector3(29.1f, -5.7838f, 0f);
        Vector3 ballPosition = new Vector3(whiteBall.transform.position.x, whiteBall.transform.position.y, whiteBall.transform.position.z);
        Vector3 directionToGoal = goalPosition - ballPosition;

        Rigidbody2D ballrb = whiteBall.GetComponent<Rigidbody2D>();

        if (collision.gameObject.tag == "AI" && collision.gameObject.tag == "Ball")
        {
          ballrb.AddForce(directionToGoal * puckSpeed, ForceMode2D.Impulse);  
        }
    }
}
