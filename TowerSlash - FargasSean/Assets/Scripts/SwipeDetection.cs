using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class SwipeDetection : MonoBehaviour
{
    //[SerializeField] private TextMeshProUGUI debugText;

    //private Vector2 initialTouchPosition;
    //private Vector2 endTouchPosition;

    //void Update()
    //{
    //    if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
    //    {
    //        Touch touch = Input.GetTouch(0);
    //        initialTouchPosition = touch.position;
    //    }

    //    if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
    //    {
    //        Touch touch = Input.GetTouch(0);
    //        endTouchPosition = touch.position;

    //        CheckSwipe();
    //    }
    //}

    //private void CheckSwipe()
    //{
    //    if (initialTouchPosition.x < endTouchPosition.x)
    //    {
    //        debugText.text = "Swiped Right";
    //    }

    //    if (initialTouchPosition.x > endTouchPosition.x)
    //    {
    //        debugText.text = "Swiped Left";
    //    }

    //    if (initialTouchPosition.y < endTouchPosition.y)
    //    {
    //        debugText.text = "Swiped Up";
    //    }

    //    if (initialTouchPosition.y > endTouchPosition.y)
    //    {
    //        debugText.text = "Swiped Down";
    //    }
    //}

    [SerializeField] private TextMeshProUGUI debugText;

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
            currentTouchPos = Input.GetTouch(0).position;
            Vector2 Distance = currentTouchPos - startTouchPos;

            if (!stopTouch)
            {
                if (Distance.x < -swipeRange)
                {
                    playerInput = "left";
                    Debug.Log("Swipe Left");
                    debugText.text = "Swipe Left";
                    stopTouch = true;
                }
                else if (Distance.x > swipeRange)
                {
                    playerInput = "right";
                    Debug.Log("Swipe Right");
                    debugText.text = "Swipe Right";
                    stopTouch = true;
                }
                else if (Distance.y > swipeRange)
                {
                    playerInput = "up";
                    Debug.Log("Swipe Up");
                    debugText.text = "Swipe Up";
                    stopTouch = true;
                }
                else if (Distance.y < -swipeRange)
                {
                    playerInput = "down";
                    Debug.Log("Swipe Down");
                    debugText.text = "Swipe Down";
                    stopTouch = true;
                }
            }
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;

            endTouchPos = Input.GetTouch(0).position;

            Vector2 Distance = endTouchPos - startTouchPos;

            if (Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
                playerInput = "tap";
                //Debug.Log("Tap");
            }
        }
    }
}
