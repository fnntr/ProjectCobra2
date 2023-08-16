using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 0;
    public float jumpForce = 6;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(dirx * speed, rb.velocity.y);

        if (Input.GetButton("Jump"))
        {
           
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            



        }


    }
}
