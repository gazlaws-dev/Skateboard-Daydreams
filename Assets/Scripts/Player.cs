using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //If going up
        if(rb.velocity.y > 0 )
        {
            animator.SetBool("IsJumping", true);
            animator.SetBool("IsFalling", false);
            //Debug.Log("jumping to:"+ rb.position);
        }
        if (rb.velocity.y < 0)
        {   //is falling
            animator.SetBool("IsJumping", false);
            animator.SetBool("IsFalling", true);
        }
        if (rb.velocity.y == 0)
        {   //is falling
            animator.SetBool("IsJumping", false);
            animator.SetBool("IsFalling", false);
        }
    }


}
