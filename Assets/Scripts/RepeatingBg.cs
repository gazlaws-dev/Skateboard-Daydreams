using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RepeatingBg : MonoBehaviour
{
    private BoxCollider2D boxCollider;

    private Rigidbody2D rb;
    private float width;

    public float speed;
    //public float endX;
    //public float startX;
    //private float length;

    //// Use this for initialization
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent < Rigidbody2D>();
        width = boxCollider.size.x;
        rb.velocity = new Vector2(speed, 0);
    //        length = GetComponent<SpriteRenderer>().bounds.size.x * 2;
    }


    //// Update is called once per frame
    void Update()
    {
        if (transform.position.x < -width)
        {
            //bg moved behind character
            Reposition();
        }

    //    transform.Translate(Vector2.left * speed * Time.deltaTime);
    //    if(transform.position.x <= endX)
    //    {
    //        Vector2 pos = new Vector2(transform.position.x + length, transform.position.y);
    //        transform.position = pos;
    //    }
    }

    private void Reposition() {
        Vector2 vector = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + vector;
    }
}
