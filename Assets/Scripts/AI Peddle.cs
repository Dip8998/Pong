using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    public Transform ball; // Reference to the ball GameObject
                           // Speed at which the paddle moves
    public float paddleSpeed;

    void Update()
    {
        // Ensure the ball reference is set
        if (ball == null)
        {
            Debug.LogError("Ball reference is not set for AI paddle!");
            return;
        }

        
            // if ball postion greater than center postion towarrds x axis
        if(ball.transform.position.x > 0.0f)
        {
            // If the ball is above the paddle, move the paddle up
            if (ball.transform.position.y > transform.position.y + 1f)
            {
                transform.Translate(Vector2.up * paddleSpeed * Time.deltaTime);
            }
            // If the ball is below the paddle, move the paddle down
            else if (ball.transform.position.y < transform.position.y + 1f)
            {
                transform.Translate(Vector2.down * paddleSpeed * Time.deltaTime);
            }
        }    
        
        
      
    }
}
