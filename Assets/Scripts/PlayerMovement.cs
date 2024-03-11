using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
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
    public Animator animator;
=======
=======
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b
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
<<<<<<< HEAD
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b
=======
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b


    // Update is called once per frame
    void Update()
    {
        moveDirectionX = Input.GetAxisRaw("Horizontal");

        //Debug.Log(moveDirectionX);

<<<<<<< HEAD
<<<<<<< HEAD
        if (Input.GetButtonDown("Jump") && currentNumberOfJumps < nbMaxJumpsAllowed)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            currentNumberOfJumps += 1;
        }

        if (!Input.GetButton("Jump") && isOnGround)
=======
=======
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b
        if( Input.GetButtonDown("Jump")&&
        currentNumberOfJumps < nbMaxJumpsAllowed )
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpForce);
            currentNumberOfJumps += 1; 
        }
        
        if(!Input.GetButton("Jump")&& isOnGround )
<<<<<<< HEAD
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b
=======
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b
        {
            currentNumberOfJumps = 0;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirectionX * moveSpeed, rb.velocity.y);
        isOnGround = isOnGrounded();

        Flip(moveDirectionX);
        animator.SetFloat("VelocityX", Mathf.Abs(rb.velocity.x)); // Utilisation de Mathf.Abs pour la vitesse absolue
    }

    public void Flip(float direction)
    {
        if ((direction > 0 && !isFacingRight) || (direction < 0 && isFacingRight))
        {
            rb.transform.Rotate(0, 180, 0); // Utilisation de rb.transform pour la rotation du personnage
            isFacingRight = !isFacingRight;
        }
    }

    public bool isOnGrounded()
    {
        return Physics2D.OverlapCircle(
            groundCheck.position,
            groundCheckRadius,
            listGroundLayers
        );
    }

    private void OnDrawGizmos()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(
                groundCheck.position,
                groundCheckRadius
            );
        }
    }
 
=======
=======
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b
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

<<<<<<< HEAD
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b
=======
>>>>>>> 66f3e245e48ff46e264124e9184def235d17a21b
}
