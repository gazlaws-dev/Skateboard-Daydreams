using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RepeatingBg : MonoBehaviour
{
    //Source: https://www.youtube.com/watch?v=P3hcopOkpa8
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb;
    private float width;

    //public float speed;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent < Rigidbody2D>();
        width = boxCollider.size.x;
        //infinite move backward
        rb.velocity = new Vector2(-Global.backgroundSpeed, 0);
    }


    //// Update is called once per frame
    void Update()
    {
        //If right edge of bg moved completely behind the character
        if (transform.position.x+width < 0)
        {
            Reposition();
        }

    }

    private void Reposition() {
        //Move forward 2 times - to go just beyond next bg
        Vector2 vector = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + vector;
    }
}
