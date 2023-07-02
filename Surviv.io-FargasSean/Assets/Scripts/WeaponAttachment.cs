using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class WeaponAttachment : MonoBehaviour
{
    int weaponTotal = 1;
    public static int currentWeaponIndex = 1;

    public GameObject[] guns;
    public GameObject weaponHolder;
    public GameObject currentGun;

    void Start()
    {
        weaponTotal = weaponHolder.transform.childCount;
        guns = new GameObject[weaponTotal];

        for (int i = 0; i < weaponTotal; i++)
        {
            guns[i] = weaponHolder.transform.GetChild(i).gameObject;
            guns[i].SetActive(false);
        }

        // Set Pistol as Default
        guns[0].SetActive(true);
        Debug.Log("Set Pistol Default");
        currentGun = guns[0];
        currentWeaponIndex = 0;
    }
}
