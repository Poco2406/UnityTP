using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
      public Rigidbody2D rb; 

    // Player's direction
      public float moveDirectionX = 0f;
      public float moveSpeed = 5f;
      public float jumpForce = 7f;

      public int nbMaxJumpsAllowed = 2;
      public int currentNumberOfJumps = 0; 

      public Transform groundCheck;
      public float groundCheckRadius = 0.2f;
      public bool isOnGround = true;
      public LayerMask listGroundLayers;

      public bool isFacingRight = true;


    // Update is called once per frame
    void Update()
    {
        moveDirectionX = Input.GetAxisRaw("Horizontal");

        //Debug.Log(moveDirectionX);

        if( Input.GetButtonDown("Jump")&&
        currentNumberOfJumps < nbMaxJumpsAllowed )
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpForce);
            currentNumberOfJumps += 1; 
        }
        
        if(!Input.GetButton("Jump")&& isOnGround )
        {
            currentNumberOfJumps = 0;
        }

    }

    private void FixedUpdate() {
        rb.velocity = new Vector2( moveDirectionX * moveSpeed, rb.velocity.y);
        isOnGround = isOnGrounded();
    }

    public bool isOnGrounded(){
        return Physics2D.OverlapCircle( 
       groundCheck.position,
       groundCheckRadius,
       listGroundLayers
        );
    }

}
