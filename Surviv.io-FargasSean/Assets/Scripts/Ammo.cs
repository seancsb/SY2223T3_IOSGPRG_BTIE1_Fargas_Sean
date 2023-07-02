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
            //if (collision.name == "Player")
            //{
                //ammoDisplay.ammoCapacity += 30;

                // Add Ammo to Specified Gun Ammo
                // Sets the Ammo Display for this gun to true
                shoot.AddAmmo(shoot.maxAmmoSize);
                Destroy(gameObject);
                //Debug.Log("pickup");
            //}
        }
    }
}
