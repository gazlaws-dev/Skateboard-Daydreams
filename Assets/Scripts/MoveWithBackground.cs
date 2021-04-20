using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithBackground : MonoBehaviour
{
    //make sure it matches background speed
    //public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*Global.backgroundSpeed*Time.deltaTime);
    }
}
