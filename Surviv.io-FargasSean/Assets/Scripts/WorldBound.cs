using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBound : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.7f, 8.7f), Mathf.Clamp(transform.position.y, -4.8f, 4.8f), transform.position.z);
    }
}
