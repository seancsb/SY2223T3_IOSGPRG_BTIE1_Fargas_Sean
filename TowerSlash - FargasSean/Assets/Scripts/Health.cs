using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    Text healthText;
    public static int hp = 3;

    void Start()
    {
        healthText = GetComponent<Text>();        
    }

    void Update()
    {
        healthText.text = "HEALTH: " + hp;

        if (hp < 1)
        {
            hp = 3;
            Scoring.points = 0;
            SceneManager.LoadScene("GameOver");
        }
    }
}
