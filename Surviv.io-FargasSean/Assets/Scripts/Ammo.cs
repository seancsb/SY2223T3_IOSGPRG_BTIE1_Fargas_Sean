using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] public AmmoDisplay ammoDisplay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Shoot shoot = collision.gameObject.GetComponentInChildren<Shoot>();

        if (shoot)
        {
            shoot.AddAmmo(shoot.maxAmmoSize);
            Destroy(gameObject);
        }
    }
}
