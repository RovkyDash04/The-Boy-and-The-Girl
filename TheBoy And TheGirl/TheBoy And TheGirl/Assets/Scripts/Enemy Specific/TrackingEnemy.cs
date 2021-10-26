using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingEnemy : MonoBehaviour {
    private Transform target;
    public float speed;

    public bool Grounded;
    public Transform feet;
    public float groundCheckRad;
    public LayerMask ground;
    public float RunSpeed;
    public Rigidbody2D RB;
    public Animator anim;
    public float JumpStrength = 20f;
    public Transform Player1;
    public Transform Player2;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update() {
        
        if (Vector2.Distance(transform.position,Player1.position) < 12)
        {
            target = Player1;
        } else
        {
            target = Player2;
        }
        
        
        
        Grounded = Physics2D.OverlapCircle(feet.position, groundCheckRad, ground);

        if ((Vector2.Distance(transform.position, target.position) < 12))
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            if (target.transform.position.x > gameObject.transform.position.x)
            {
                RB.velocity = new Vector2(RunSpeed, RB.velocity.y);
                anim.SetBool("Running", true);
                transform.localScale = new Vector3(1f, 1f, 1f);
            } else if (gameObject.transform.position.x > target.transform.position.x)
            {
                RB.velocity = new Vector2(-RunSpeed, RB.velocity.y);
                anim.SetBool("Running", true);
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }
            else
            {
                RB.velocity = new Vector2(0, RB.velocity.y);
                anim.SetBool("Running", false);
            }

            if ((!Grounded))
            {
                anim.SetBool("Grounded", false);

            } else if ((Grounded) && (target.transform.position.y > gameObject.transform.position.y))
            {
                RB.velocity = new Vector2(RB.velocity.x, JumpStrength);
                anim.SetBool("Grounded", true);

            }
            else
            {
                anim.SetBool("Grounded", true);
            }


        }

        if (Vector2.Distance(transform.position, target.position) > 10)
        {
            anim.SetBool("Running", false);
            anim.SetBool("Grounded", true);
        }
    }
}
