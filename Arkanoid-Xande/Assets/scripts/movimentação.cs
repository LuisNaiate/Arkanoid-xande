using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentação : MonoBehaviour
{
    float horizontal;
     private Rigidbody2D body;
    private int speed = 22;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);
    }
}
