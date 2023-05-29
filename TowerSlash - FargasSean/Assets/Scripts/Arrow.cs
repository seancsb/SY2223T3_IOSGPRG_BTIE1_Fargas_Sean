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

    void Start()
    {
        spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length - 1)];

        // Green Arrows
        if (spriteRenderer.sprite == sprites[0])
        {
            enemy.swipeDir = "left";
            Debug.Log(enemy.swipeDir);
        }

        else if (spriteRenderer.sprite == sprites[1])
        {
            enemy.swipeDir = "right";
            Debug.Log(enemy.swipeDir);
        }

        else if (spriteRenderer.sprite == sprites[2])
        {
            enemy.swipeDir = "down";
            Debug.Log(enemy.swipeDir);
        }

        else if (spriteRenderer.sprite == sprites[3])
        {
            enemy.swipeDir = "up";
            Debug.Log(enemy.swipeDir);
        }

        // Red Arrows
        else if (spriteRenderer.sprite == sprites[4])
        {
            enemy.swipeDir = "right";
            Debug.Log(enemy.swipeDir);
        }

        else if (spriteRenderer.sprite == sprites[5])
        {
            enemy.swipeDir = "left";
            Debug.Log(enemy.swipeDir);
        }

        else if (spriteRenderer.sprite == sprites[6])
        {
            enemy.swipeDir = "up";
            Debug.Log(enemy.swipeDir);
        }

        else if (spriteRenderer.sprite == sprites[7])
        {
            enemy.swipeDir = "down";
            Debug.Log(enemy.swipeDir);
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "endPoint")
        {
            enemy.despawnEnemy();
        }
    }
}
