using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball1"))
        {
            // Score increment for enemy
            ScoreIncrement.Instance.UpdateMyScore();

        }
        if (collision.gameObject.CompareTag("Ball2"))
        {
            // Score increment for enemy
            ScoreIncrement2.Instance.UpdateMyScore();

        }


    }
}
