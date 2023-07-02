using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            //ammoDisplay.ammoCapacity += 30;
            Destroy(gameObject);
            //Debug.Log("pickup");
        }
    }
}
