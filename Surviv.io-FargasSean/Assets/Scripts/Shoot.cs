using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] public GameObject bulletPref; 
    [SerializeField] public float bulletSpeed;

    [SerializeField] private float timeBetweenShots;
    
    private float lastFireTime;

    private bool isFiring;
    private bool stopFiring;

    public int currentClip = 15, maxClipSize = 15, currentAmmo = 30, maxAmmoSize = 90;

    public virtual void Start()
    {
        // Debug Ammo

        Debug.Log("CLIP: " + currentClip);
        Debug.Log("AMMO: " + currentAmmo);
    }

    private void Update()
    {
       if (isFiring)
        {
            isFiring = false;
            Invoke("makeFireVariableTrue", 0f);
            Fire();
        }

       if (currentAmmo <= 0)
        {
            Reload();
        }
    }

    public void pointerDown()
    {
        stopFiring = false;
        Invoke("makeFireVariableTrue", 0f);
    }

    public void pointerUp()
    {
        isFiring = false;
        stopFiring = true;
    }

    public void FireBullet()
    {
        if (currentClip > 0)
        {
            GameObject bullet = Instantiate(bulletPref, transform.position, transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

            rb.velocity = bulletSpeed * transform.up;
            currentClip--;
        }
    }

    public void Reload()
    {
        int reloadAmount = maxClipSize - currentClip; // How Many Bullets to Refill Clip
        reloadAmount = (currentAmmo - reloadAmount) >= 0 ? reloadAmount : currentAmmo;
        currentClip += reloadAmount;
        currentAmmo -= reloadAmount;
    }

    public void AddAmmo(int ammoAmount)
    {
        currentAmmo += ammoAmount;
        if (currentAmmo > maxAmmoSize)
        {
            currentAmmo = maxAmmoSize;
        }
    }

    public void Fire()
    {
        float timeSinceLastFire = Time.time - lastFireTime;

        if (timeSinceLastFire >= timeBetweenShots)
        {
            FireBullet();

            lastFireTime = Time.time;
        }
    }
}
