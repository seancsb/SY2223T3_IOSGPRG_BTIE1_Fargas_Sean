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

    void Start()
    {
        if (Randomization >= 0)
        {
            Randomization = Random.Range(0, 7);
        }

        // Green Arrows
        if (Randomization == 0)
        {
            enemy.swipeDir = "left";
            spriteRenderer.sprite = sprites[0];
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (Randomization == 1)
        {
            enemy.swipeDir = "right";
            spriteRenderer.sprite = sprites[1];
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (Randomization == 2)
        {
            enemy.swipeDir = "down";
            spriteRenderer.sprite = sprites[2];
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (Randomization == 3)
        {
            enemy.swipeDir = "up";
            spriteRenderer.sprite = sprites[3];
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        // Red Arrows
        if (Randomization == 4)
        {
            enemy.swipeDir = "right";
            spriteRenderer.sprite = sprites[0];
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (Randomization == 5)
        {
            enemy.swipeDir = "left";
            spriteRenderer.sprite = sprites[1];
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (Randomization == 6)
        {
            enemy.swipeDir = "up";
            spriteRenderer.sprite = sprites[2];
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (Randomization == 7)
        {
            enemy.swipeDir = "down";
            spriteRenderer.sprite = sprites[3];
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
