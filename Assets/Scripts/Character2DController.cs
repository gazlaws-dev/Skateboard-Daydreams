using System.Threading;
using UnityEngine;

public class Character2DController : MonoBehaviour
{
    //Source: https://www.youtube.com/watch?v=n4N9VEA2GFo
    //Don't need movement since world moves constantly
    //public float movementSpeed = 1 ;
    public float jumpForce = 15 ;

    public float fallMultiplier = 2.5f;

    private Rigidbody2D rb;
    public float jumpHeight;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        

    }
    void FixedUpdate()
    {
        var movement = VirtualDPad.direction; //Up , Tapped
        VirtualDPad.direction = "None";

        //Only allow a single jump -> iff not already going up
        if (movement == "Up" && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            //rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            rb.AddForce(Vector2.up*jumpHeight, ForceMode2D.Impulse);
        }

        //faster falling
        if (rb.velocity.y < 0)
        {
            rb.velocity += Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
        }
    }
}
