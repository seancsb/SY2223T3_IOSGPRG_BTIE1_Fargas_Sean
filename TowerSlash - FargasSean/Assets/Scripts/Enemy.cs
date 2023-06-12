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

    private int dropPercentage;

    private DashManager dashManager;

    void Start()
    {
        input.playerInput = "default";
        dashManager = GameObject.Find("DashManager").GetComponent<DashManager>();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "endPoint")
        {
            Health.hp--;
            despawnEnemy();
        }

        if (col.gameObject.tag == "inBound")
        {
            input.playerInput = "default";
            enemyKillable = true;
        }
    }

    void Update()
    {
        transform.Translate(Vector2.down * currentSpeed * Time.deltaTime);

        dropPercentage = Random.Range(0, 10);

        if (enemyKillable == true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            if (input.playerInput == swipeDir)
            {
                killEnemy();
            }
        }
    }

    public void killEnemy()
    {
        Scoring.points++;

        if (dropPercentage <= 1)
        {
            Health.hp++;
            Debug.Log("You have received an extra life!");
        }

        dashManager.AddDashPoints(5);

        Destroy(gameObject);
    }

    public void despawnEnemy()
    {
        Destroy(gameObject);

        input.playerInput = "default";
    }
}
