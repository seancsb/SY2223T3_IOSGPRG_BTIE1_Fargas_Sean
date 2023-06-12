using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Enemy Sprites
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] sprites;

    [SerializeField] SwipeDetection input;
    [SerializeField] Enemy enemy;

    private int Randomization = 7;
    //private int Randomization = 0;

    void Start()
    {
        if (Randomization >= 0)
        {
            Randomization = Random.Range(0, 7);
        }

        //while(true)
        //{
        //    Randomization = Random.Range(0, 7);
        //}

        if (Randomization == 0)
        {
            enemy.swipeDir = "left";
            Debug.Log(enemy.swipeDir);
            spriteRenderer.sprite = sprites[0];
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (Randomization == 1)
        {
            enemy.swipeDir = "right";
            Debug.Log(enemy.swipeDir);
            spriteRenderer.sprite = sprites[1];
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (Randomization == 2)
        {
            enemy.swipeDir = "down";
            Debug.Log(enemy.swipeDir);
            spriteRenderer.sprite = sprites[2];
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (Randomization == 3)
        {
            enemy.swipeDir = "up";
            Debug.Log(enemy.swipeDir);
            spriteRenderer.sprite = sprites[3];
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (Randomization == 4)
        {
            enemy.swipeDir = "right";
            Debug.Log(enemy.swipeDir);
            spriteRenderer.sprite = sprites[0];
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (Randomization == 5)
        {
            enemy.swipeDir = "left";
            Debug.Log(enemy.swipeDir);
            spriteRenderer.sprite = sprites[1];
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (Randomization == 6)
        {
            enemy.swipeDir = "up";
            Debug.Log(enemy.swipeDir);
            spriteRenderer.sprite = sprites[2];
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (Randomization == 7)
        {
            enemy.swipeDir = "down";
            Debug.Log(enemy.swipeDir);
            spriteRenderer.sprite = sprites[3];
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "endPoint")
        {
            enemy.despawnEnemy();
        }
    }
}
