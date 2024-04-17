using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTrigger : MonoBehaviour
{
    public DoubleTouch doubleTouch;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        doubleTouch.playerCollisionCount = 0;
        doubleTouch.AICollisionCount = 0;
    }
}
