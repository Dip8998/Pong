using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualPeddle : MonoBehaviour
{
    public float speed;
 
    void FixedUpdate()
    {
        // if player postion -3.5 or 3.5 on y axis
        if(transform.position.y > -3.5f || transform.position.y < 3.5f)
        {
            float verticalInput = Input.GetAxis("Vertical 1") * speed * Time.deltaTime;
            transform.Translate(0, verticalInput, 0);
        }
      
        
    }
   
}
