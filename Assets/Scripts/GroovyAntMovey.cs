using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroovyAntMovey : MonoBehaviour
{
    // Public Movement Variables
    public float MovementSpeed = 30;
    public float JumpForce = 10;
    public float Friction = 0.5f;
    public float JumpCheckDistance = -5.3f;

    public Animator animatorName;
    
    // Main player rigidbody
    private Rigidbody2D PlayerRigidbody;

    // Player sprite flip bool
    private bool facingRight = true;
    
    // Jump variables
    private bool isGrounded = false;
    private bool isJumping = false;
    private Vector2 extents;
    private float groundTime;

    private void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody2D>();
        extents = GetComponent<BoxCollider2D>().bounds.size;
        extents.x = extents.x - 0.1f;
        extents.y = 0.5f;
    }

    private void FixedUpdate()
    {
        // Get the horizontal input
        var horizontal = Input.GetAxis("Horizontal");
        
        // Player sprite flip
        if (horizontal > 0 && !facingRight) Flip();
        else if (horizontal < 0 && facingRight) Flip();

        // move the player
        Movement(horizontal);
        
        // Ground check 
        isGrounded = Physics2D.OverlapBox(transform.position - Vector3.down * JumpCheckDistance,
            extents, 0, LayerMask.GetMask("Ground"));
    }
    
    private void Update()
    {
        // Jump check
        if (isGrounded)
        {
            isJumping = false;
            groundTime += Time.deltaTime;
        }

        // Jump input
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Flip()
    {
        facingRight = !facingRight;
        var theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void Movement(float horizontal)
    {
        // Determine the plater velocity
        var targetVelocityX = horizontal * MovementSpeed;
        
        // Determine tha mount of force to apply to the player
        var speedDifference = targetVelocityX - PlayerRigidbody.velocity.x;
        var accelreationRate = (Mathf.Abs(targetVelocityX) < 0.01f) ? 0.5f : 0.8f;
        
        // Generate a general force to apply to the player
        var movement = Mathf.Pow(Mathf.Abs(speedDifference) * accelreationRate, 2) * Mathf.Sign(speedDifference);
        
        // Apply the force to the player, only affects the x axis so we multiply by Vector2.right
        PlayerRigidbody.AddForce(movement * Vector2.right);
        
        // Friction
        if (Mathf.Abs(horizontal) < 0.01f)
        {
            // The amount of friction to apply is the minimum of the friction value or the player's current velocity
            var amount = Mathf.Min(Mathf.Abs(Friction), Mathf.Abs(PlayerRigidbody.velocity.x));
            
            // Multiply the amount by the sign of the player's velocity in the x axis
            amount *= Mathf.Sign(PlayerRigidbody.velocity.x);
            
            // Apply the friction
            PlayerRigidbody.AddForce(-amount * Vector2.right, ForceMode2D.Impulse);
        }
    }

    
    private void Jump()
    {
        // Check if the player is already jumping or has been on the ground for less than 0.05 seconds
        if (isJumping || groundTime < 0.05F) return;
        
        // Apply an impulse force upwards
        PlayerRigidbody.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        
        // Set the jump flag
        isJumping = true;
        
        // Reset the ground time
        groundTime = 0;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        // Draw the jump check box
        Gizmos.DrawWireCube(transform.position - Vector3.down * JumpCheckDistance, extents);
    }
}