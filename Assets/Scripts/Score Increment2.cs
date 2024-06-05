using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreIncrement2 : MonoBehaviour
{
    public static ScoreIncrement2 Instance;

    [SerializeField] private TextMeshProUGUI _myScore;
    [SerializeField] private TextMeshProUGUI _aiScore;
    [SerializeField] private GameObject _pauseCaanvas;
   

    private int _score;
    private int _ai;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {
        _myScore.text = _score.ToString();
        _aiScore.text = _ai.ToString();
    }

    // Update is called once per frame
    public void UpdateMyScore()
    {
        _score++;
        _myScore.text = _score.ToString();
        if (_score > 15)
        {
            GameManager2.Instance.GameOverForPlayer();
            
        }
    }
    public void UpdateAIScore()
    { 
        _ai++;
        _aiScore.text = _ai.ToString();
        if (_ai > 15)
        {
            GameManager2.Instance.GameOverForEnemy();
            
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        _pauseCaanvas.gameObject.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1.0f;
        _pauseCaanvas.gameObject.SetActive(false);
    }
    

   
}
