using System.Collections;
using System.Collections.Generic;
//using UnityEditor.U2D.IK;
using UnityEngine;

public class EnemyYellow : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] sprites;

    [SerializeField] private bool isPlayerNear = false;

    [SerializeField] SwipeDetection input;
    [SerializeField] Enemy enemy;

    private void Start()
    {
        StartCoroutine(Tick());
        enemy.swipeDir = "na";
        gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
        spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length - 1)];
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "inBound")
        {
            isPlayerNear = true;
        }
    }

    private IEnumerator Tick()
    {
        while (!isPlayerNear)
        {
            spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length - 1)];
            yield return new WaitForSeconds(0.15f);

        }

        int arrowRand = Random.Range(0, sprites.Length - 1);
        spriteRenderer.sprite = sprites[arrowRand];

        // Yellow Arrows
        if (spriteRenderer.sprite == sprites[0])
        {
            enemy.swipeDir = "left";
        }

        else if (spriteRenderer.sprite == sprites[1])
        {
            enemy.swipeDir = "right";
        }

        else if (spriteRenderer.sprite == sprites[2])
        {
            enemy.swipeDir = "down";
        }

        else if (spriteRenderer.sprite == sprites[3])
        {
            enemy.swipeDir = "up";
        }
    }
}
