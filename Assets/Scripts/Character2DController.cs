using System.Threading;
using UnityEngine;

public class Character2DController : MonoBehaviour
{
    //public float movementSpeed = 1 ;
    public float jumpForce = 15 ;

    private Rigidbody2D _rigidbody;
    void Start() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var movement = VirtualDPad.direction; //Up , Tapped
        VirtualDPad.direction = "None";

        if (movement == "Up" && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
