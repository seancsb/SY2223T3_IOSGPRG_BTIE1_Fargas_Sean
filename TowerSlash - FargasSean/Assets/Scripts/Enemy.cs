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

    [SerializeField]
    int currentSpeed;

    int dropPercentage;

    [SerializeField] public bool enemyKillable;

    void Start()
    {
        enemyKillable = false;
        //Debug.Log("GAME START");
    }

    void Update()
    {
        transform.Translate(Vector2.down * currentSpeed * Time.deltaTime);

        dropPercentage = Random.Range(0, 10);

        if (enemyKillable == true)
        {
            if (input.playerInput == swipeDir)
            {
                killEnemy();
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.gameObject.tag == "killableEnemy")
        //{
        //    enemyKillable = true;
        //    Debug.Log("KILLABLE ENEMY");
        //}

        if (col.gameObject.tag == "endPoint")
        {
            despawnEnemy();
            Debug.Log("PASSSED PLAYER");
        }
    }

    public void killEnemy()
    {
        if (dropPercentage <= 1)
        {
            Debug.Log("You have received an extra life!");
        }

        Destroy(gameObject);
    }

    public void despawnEnemy()
    {
        Destroy(gameObject);
    }
}
