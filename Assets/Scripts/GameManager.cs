using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private GameObject _gameOverPlayerCanvas, _gameOverEnemyCanvas, _scoreCanvas;// asigning the game object to the Inspector

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        Time.timeScale = 1.0f;
    }
   
    public void GameOverForEnemy()
    {
        // Appears Game over screen if player win
        _gameOverEnemyCanvas.gameObject.SetActive(true);
        _scoreCanvas.gameObject.SetActive(false);
        Time.timeScale = 0f;

    }
    public void GameOverForPlayer()
    {
        // Appears game over screen if player lost
        _gameOverPlayerCanvas.gameObject.SetActive(true);
        _scoreCanvas.gameObject.SetActive(false);
        Time.timeScale = 0f;
    }
    public void RestartGame()
    {
        // restart the game
        SceneManager.LoadScene(1);
        
    }
   
    public void Menu()
    {
        // Load main menu
        SceneManager.LoadScene(0);
    }
}
