using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour
{
    public void ResetGame()
    {
        SceneManager.LoadScene("Game");
        //Debug.Log("GameOver");
    }

    public void ChangeCharacter()
    {
        SceneManager.LoadScene("CharacterSelection");
        //Debug.Log("Char Selection");
    }
}