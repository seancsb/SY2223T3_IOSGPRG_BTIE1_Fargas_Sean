using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAwarenessController : MonoBehaviour
{
    public bool AwareOfPlayer 
    { 
        get; 
        private set; 
    }

    public Vector2 DirectionToPlayer 
    { 
        get; 
        private set; 
    }

    [SerializeField] private float playerAwarenessDistance;

    private Transform player;

    private void Awake()
    {
        player = FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {
        Vector2 enemyToPlayerVeector = player.position - transform.position;
        DirectionToPlayer = enemyToPlayerVeector.normalized;

        if (enemyToPlayerVeector.magnitude <= playerAwarenessDistance)
        {
            AwareOfPlayer = true;
        }
        else
        {
            AwareOfPlayer = false;
        }
    }
}
