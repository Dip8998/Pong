using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScoreWall : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball1"))
        {
            // Score increment for enemy
            ScoreIncrement.Instance.UpdateAIScore();
            
        }
        if (collision.gameObject.CompareTag("Ball2"))
        {
            // Score increment for enemy
            ScoreIncrement2.Instance.UpdateAIScore();

        }

    }
}
