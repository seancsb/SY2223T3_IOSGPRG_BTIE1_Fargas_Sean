using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBound : MonoBehaviour
{
    //private Vector2 screenBounds;
    //private float objecWidth;
    //private float objecHeight;

    //void Start()
    //{
    //    screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    //    objecWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
    //    objecHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    //}

    //void LateUpdate()
    //{
    //    Vector3 viewPos = transform.position;
    //    viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + objecWidth, screenBounds.x * - 1 - objecWidth);
    //    viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objecHeight, screenBounds.y * - 1 - objecHeight);
    //    transform.position = viewPos;
    //}

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.7f, 8.7f), Mathf.Clamp(transform.position.y, -4.8f, 4.8f), transform.position.z);
    }
}
