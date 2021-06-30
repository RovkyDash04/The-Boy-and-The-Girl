using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;


    public Animator anim;

    public float JumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;

    float mx;

    private void Start()
    {
    }

    private void Update() {
      mx = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded()) {
            SoundManager.PlaySound("Jump");
            Jump();
        }

        if (Mathf.Abs(mx) > 0.05f)
        {
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }

        if (mx > 0f)
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
        }
        else if (mx < 0f)
        {
            transform.localScale = new Vector3(-2f, 2f, 2f);
        }

        anim.SetBool("IsGrounded", IsGrounded());
    }
    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }

    void Jump() {
        Vector2 movement = new Vector2(rb.velocity.x, JumpForce);

        rb.velocity = movement;
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }

        return false;
    }
}