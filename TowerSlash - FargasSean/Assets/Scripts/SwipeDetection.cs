using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class SwipeDetection : MonoBehaviour
{
     private Vector2 startTouchPos;
    private Vector2 currentTouchPos;
    private Vector2 endTouchPos;

    private bool stopTouch = false;

    public float swipeRange;
    public float tapRange;

    public string playerInput = "default";

    private void Update()
    {
        Swipe();
    }

    public void Swipe()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            currentTouchPos = Input.GetTouch(0).position;
            Vector2 Distance = currentTouchPos - startTouchPos;

            if (!stopTouch)
            {
                if (Distance.x < -swipeRange)
                {
                    playerInput = "left";
                    stopTouch = true;
                }
                else if (Distance.x > swipeRange)
                {
                    playerInput = "right";
                    stopTouch = true;
                }
                else if (Distance.y > swipeRange)
                {
                    playerInput = "up";
                    stopTouch = true;
                }
                else if (Distance.y < -swipeRange)
                {
                    playerInput = "down";
                    stopTouch = true;
                }
            }

            stopTouch = false;

            endTouchPos = Input.GetTouch(0).position;

            Distance = endTouchPos - startTouchPos;

            if (Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
                playerInput = "tap";
            }
        }
    }
}
