using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
   
    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private int _time;
    void Start()
    { 
        _timerText.text = _time.ToString();
        StartCoroutine(StartCountDown());
    }

   IEnumerator StartCountDown()
    {
        while (_time >= 0)
        {
            _timerText.text = _time.ToString();
            yield return new WaitForSeconds(1);
            _time--;

            
            if (_time == 0)
            {
                SceneManager.LoadScene(2);
            }
        }
       
    }
}
