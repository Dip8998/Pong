using UnityEngine;

public class Ball : MonoBehaviour
{
     // Speed of the ball

    private Rigidbody2D rb;
    private AudioSource audioSource;
    [SerializeField] private AudioClip target;
   

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
         rb = GetComponent<Rigidbody2D>();
         float speed = Random.Range(9, 13);
         rb.velocity = new Vector2(speed,speed);
       
    }

    private void FixedUpdate()
    {
        if(transform.position.x > 10f)
        {
            transform.position = new Vector2(0, 0);
        }
        else if (transform.position.x < -10f)
        {
            transform.position = new Vector2(0, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            float speed = Random.Range(6, 12);
            float x = Random.value < 0.5f ? -1f : 1f;
            float y  = Random.value < 0.5f ? Random.Range(-1f, 1f) : Random.Range(0.5f,1.0f);
            
            rb.velocity = new Vector2(speed *1.1f *x, speed  *1.1f *y);
            audioSource.clip = target;
            audioSource.Play();
        }
        
    }
}
