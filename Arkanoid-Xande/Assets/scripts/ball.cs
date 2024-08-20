using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private float speed = 25;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;




    }



    // Update is called once per frame
    void Update()
    {

    }

    float HitFactor(Vector2 ball, Vector2 player, float playerWidth)
    {
        return (ball.x - player.x) / playerWidth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            float x = HitFactor(transform.position,
                collision.transform.position,
                collision.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;


            rb.velocity = dir * speed;
        }

    }
}
