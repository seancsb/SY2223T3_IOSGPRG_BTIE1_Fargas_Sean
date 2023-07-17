using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] public string unitName;
    [SerializeField] public float movementSpeed;

    [SerializeField] public float health = 100f;
    public Image healthBar;

    [SerializeField] private Shoot gun;

    private void Shoot()
    {
        
    }

    private void Reload()
    {

    }

    private void Move()
    {

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.fillAmount = health / 100f;

        if (health <= 0)
        {
            

        }
    }

    public void Heal(float healing)
    {
        health += healing;
        health = Mathf.Clamp(health, 0, 100);

        healthBar.fillAmount = health / 100f;
    }

    public void Update()
    {
        if (health <= 0)
        {
            
            Debug.Log("Dead");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamage(20);
            Debug.Log("TakeDamage");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Heal(5);
            Debug.Log("Heal");
        }
    }
}
