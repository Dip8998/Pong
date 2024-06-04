using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScoreWall : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Score increment for enemy
            ScoreIncrement.Instance.UpdateAIScore();
           
        }
        
       
    }
}
