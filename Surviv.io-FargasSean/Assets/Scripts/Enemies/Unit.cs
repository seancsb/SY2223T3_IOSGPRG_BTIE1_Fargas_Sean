using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _currentHealth;
    [SerializeField] private int _maxHealth;
    [SerializeField] private float _speed;

    public virtual void Initialize(string name, int maxHealth, float speed)
    {
        _name = name;

        _maxHealth = maxHealth;
        _currentHealth = _maxHealth;

        _speed = speed;

        gameObject.name = name;

        Debug.Log($"{name} has been spawned");
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        _currentHealth = Mathf.Min(_currentHealth, 0);
    }


}
