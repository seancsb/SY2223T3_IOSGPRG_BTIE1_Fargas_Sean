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
        UpdateAmmoText();
    }

    public void UpdateAmmoText()
    {
        ammoText.text = $"{shoot.currentClip} / {shoot.maxAmmoSize}";
    }
}
