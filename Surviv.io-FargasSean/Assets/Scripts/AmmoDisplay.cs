using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    public Pistol shoot;
    Text ammoText;
    //public int ammoCapacity = 0;

    public void Start()
    {
        ammoText = GetComponent<Text>();
        UpdateAmmoText();

        // Debug Ammo

        //Debug.Log(shoot.currentClip);
        //Debug.Log(shoot.currentAmmo);
    }

    void Update()
    {
        UpdateAmmoText();
    }

    public void UpdateAmmoText()
    {
        //ammoText.text = $"{shoot.currentClip} / {shoot.currentAmmo}";
    }
}
