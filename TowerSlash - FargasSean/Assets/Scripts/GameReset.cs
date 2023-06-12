using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour
{
    public void ResetGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ChangeCharacter()
    {
        SceneManager.LoadScene("CharacterSelection");
    }
}