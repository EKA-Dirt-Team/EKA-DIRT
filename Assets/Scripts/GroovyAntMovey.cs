using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroovyAntMovey : MonoBehaviour
{
    //movement
    public float MovementSpeed = 10;
    public float JumpForce = 10;

    public Animator animatorName;

    private Rigidbody2D _rigidbody;

    //check if the player is moving right or left
    public bool facingRight = true;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //player movement
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        //player jump
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

            animatorName.SetBool("IsJumping", true);
        }

        //tells unity that character has stopped jumping (i think)
        if (Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            animatorName.SetBool("IsJumping", false);
        }

        //check if moving right or left
        if (movement < 0 && facingRight) Flip();
        if (movement > 0 && !facingRight) Flip();

        //changes Speed float for player animator
        animatorName.SetFloat("Speed", Mathf.Abs(movement));

        //checks if player is jumping
        void OnLanding()
        {
            animatorName.SetBool("IsJumping", false);
        }

        //flip function
        void Flip()
        {
            facingRight = !facingRight;
            transform.Rotate(Vector3.up * 180);
        }
    }
}
