using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour
{
    private Vector2 acceleration = new Vector2(1,1);
    public Rigidbody2D rigidbody2d;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        TakeInput();
    }

    void TakeInput()
    {
        Vector2 velocity = rigidbody2d.velocity;

        if(Input.GetKey(KeyCode.A))
        {
            velocity.x -= acceleration.x = Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            velocity.x += acceleration.x = Time.deltaTime;
        }

        rigidbody2d.velocity = velocity;


    }
}
