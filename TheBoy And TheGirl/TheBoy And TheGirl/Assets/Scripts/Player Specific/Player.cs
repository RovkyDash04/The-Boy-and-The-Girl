using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    public Rigidbody2D RB;

    public float movementSpeed;
    public float JumpForce = 20f;
    public float groundCheckRad;
    public Animator anim;
    public Transform feet;
    public LayerMask groundLayers;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        RB.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feet.position, groundCheckRad, groundLayers);

        if (Input.GetKey(left))
        {
            RB.velocity = new Vector2(-movementSpeed, RB.velocity.y);
            anim.SetBool("IsRunning", true);
            transform.localScale = new Vector3(-2f, 2f, 2f);
        }
        else if (Input.GetKey(right))
        {
            RB.velocity = new Vector2(movementSpeed, RB.velocity.y);
            anim.SetBool("IsRunning", true);
            transform.localScale = new Vector3(2f, 2f, 2f);
        }
        else
        {
            RB.velocity = new Vector2(0, RB.velocity.y);
            anim.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(jump) && isGrounded)
        {
            RB.velocity = new Vector2(RB.velocity.x, JumpForce);
            anim.SetBool("IsGrounded", false);
            SoundManager.PlaySound("Jump");
        }
        else
        {
            anim.SetBool("IsGrounded", true);
        }
    }
}
