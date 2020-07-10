using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Character2DController controller;
    public Animator animator;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get input from the player
        if(Mathf.Abs(_rigidbody.velocity.y) > 0 )
        {
            animator.SetBool("IsJumping", true);
        }

        if (Mathf.Abs(_rigidbody.velocity.y) == 0)
        {
            animator.SetBool("IsJumping", false);
        }
    }


}
