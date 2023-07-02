using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    public Shoot shoot;
    Text ammoText;
    public int ammoCapacity = 0;

    public void Start()
    {
        ammoText = GetComponent<Text>();
        UpdateAmmoText();
    }

    void Update()
    {
        //ammoText.text = "AMMO: " + ammoCapacity;
        UpdateAmmoText();
    }

    public void UpdateAmmoText()
    {
        //ammoText.text = $"Ammo: {shoot.currentClip} / {shoot.maxAmmoSize}";
        ammoText.text = $"Ammo: {shoot.currentClip} / {shoot.maxClipSize} | {shoot.currentAmmo} / {shoot.maxAmmoSize}";
    }
}
