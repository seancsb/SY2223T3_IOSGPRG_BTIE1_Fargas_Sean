using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Shoot
{
    public override void Start()
    {
        currentClip = 15;
        maxClipSize = 15;
        currentAmmo = 30;
        maxAmmoSize = 90;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
