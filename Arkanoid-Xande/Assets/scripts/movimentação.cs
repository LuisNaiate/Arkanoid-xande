using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movimentação : MonoBehaviour
{
    float horizontal;
     private Rigidbody2D body;
    private int speed = 22;
    public GameObject bola;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("double"))
        {
            Instantiate(bola, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
