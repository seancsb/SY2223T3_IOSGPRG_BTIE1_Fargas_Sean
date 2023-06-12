using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    [SerializeField] SwipeDetection input;

    public string swipeDir = "default";

    [SerializeField] int currentSpeed;

    [SerializeField] public bool enemyKillable = false;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "endPoint")
        {
            despawnEnemy();
            Health.hp--;
        }

        if (col.gameObject.tag == "inBound")
        {
            enemyKillable = true;
        }
    }

    void Update()
    {
        transform.Translate(Vector2.down * currentSpeed * Time.deltaTime);

        if (enemyKillable == true)
        {
            if (input.playerInput == swipeDir)
            {
                killEnemy();
            }
        }
    }

    public void killEnemy()
    {
        Scoring.points++;

        Destroy(gameObject);

        input.playerInput = "default";
    }

    public void despawnEnemy()
    {
        Destroy(gameObject);

        input.playerInput = "default";
    }
}
