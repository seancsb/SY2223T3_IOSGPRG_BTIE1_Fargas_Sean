using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    public WeaponAttachment weapon;

    void Start()
    {
        weapon = GetComponentInChildren<WeaponAttachment>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject weaponHit = col.gameObject;

        if (weaponHit.CompareTag("Pistol"))
        {
            weapon.guns[0].SetActive(true);
            weapon.guns[1].SetActive(false);
            weapon.guns[2].SetActive(false);
        }

        if (weaponHit.CompareTag("Shotgun"))
        {
            weapon.guns[0].SetActive(false);
            weapon.guns[1].SetActive(true);
            weapon.guns[2].SetActive(false);
        }

        if (weaponHit.CompareTag("MachineGun"))
        {
            weapon.guns[0].SetActive(false);
            weapon.guns[1].SetActive(false);
            weapon.guns[2].SetActive(true);
        }
    }
}
