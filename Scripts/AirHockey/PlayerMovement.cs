using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
        private bool ballMovement = false;
        private Rigidbody2D rb;


        void Start()
        {
            rb= GetComponent<Rigidbody2D>();
        }

        void Update()
        {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
            {      
                RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

                if (hit.collider != null && hit.collider.gameObject == gameObject)
                {
                    ballMovement = true;
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                ballMovement = false;
                
            }

            if (ballMovement)
            {
                rb.MovePosition(mousePosition);
            }
        }
    }

    //reference for puck and mouse position
    //for ai use addforce to move the ai  in fixedupdate or update
    //ai raycast2D target is the puck
    //read direction of the puck in relation to goal so the AI can move towards it //after
    //On MiddleBarier create a script that'll activate and deactivate the target follow of the AI (make a referece to the AI script).
    //Make refernce point (in front of the goal) and make AI move there if the follow target is deactivated.

