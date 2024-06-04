using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Start Game
        SceneManager.LoadScene(1);
    }
    public void MultiPlayer()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        // Quit game application
        Application.Quit();
    }
}
