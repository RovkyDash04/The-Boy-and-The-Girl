using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    public Rigidbody2D RB;

    public float RunSpeed;
    public float JumpStrength = 20f;
    public float groundCheckRad;
    public Animator anim;
    public Transform feet;
    public LayerMask ground;
    public bool Grounded;

    // Start is called before the first frame update
    //Calls for physics box of player
    void Start()
    {
        RB.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    //A check for all boolean states in and used by animator to animate the player characacter
    void Update()
    {
        Grounded = Physics2D.OverlapCircle(feet.position, groundCheckRad, ground);

        if (Input.GetKey(left))
        {
            RB.velocity = new Vector2(-RunSpeed, RB.velocity.y);
            anim.SetBool("Running", true);
            transform.localScale = new Vector3(-2f, 2f, 2f);
        }
        else if (Input.GetKey(right))
        {
            RB.velocity = new Vector2(RunSpeed, RB.velocity.y);
            anim.SetBool("Running", true);
            transform.localScale = new Vector3(2f, 2f, 2f);
        }
        else
        {
            RB.velocity = new Vector2(0, RB.velocity.y);
            anim.SetBool("Running", false);
        }

        if (Input.GetKeyDown(jump) && Grounded)
        {
            RB.velocity = new Vector2(RB.velocity.x, JumpStrength);
            anim.SetBool("Grounded", false);
            SoundManager.PlaySound("Jump");
        }
        else
        {
            anim.SetBool("Grounded", true);
        }
    }
}
