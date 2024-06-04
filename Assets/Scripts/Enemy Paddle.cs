using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddle : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y > -3.5f || transform.position.y < 3.5f)
        {
            float verticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.Translate(0, verticalInput, 0);
        }
      
        
    }
   
}
