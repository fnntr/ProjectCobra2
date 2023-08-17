using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 0;

    public float jumpForce = 6;



    private Rigidbody2D rb;
    public LayerMask isGround;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(dirx * speed, rb.velocity.y);


        if(dirx != 0 && dirx  > 0)
        {
            flip(180);
        } else if(dirx != 0 && dirx < 0)
        {
            flip(0);
        }

            if (Input.GetButton("Jump") && ground())
        {
           
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            



        }


    }








    private bool ground()
    {
        BoxCollider2D coll = gameObject.GetComponent<BoxCollider2D>();

        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, isGround);

    }



    void flip(float degree)
    {

        float rotationY;

        rotationY = degree;
           
            //transform.Rotate(0f, 180f, 0f);
            transform.rotation = Quaternion.Euler(transform.rotation.x, rotationY, 0);
        
    }



}
