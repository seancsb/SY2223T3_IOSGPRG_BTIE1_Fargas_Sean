using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : Shoot
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
