using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movimentação : MonoBehaviour
{
    [Header("corpo")]

    float horizontal;
     private Rigidbody2D body;
    private int speed = 22;
    Collider2D bolaColission;

    [Header("outros gameObjects")]

    public GameObject bola;
    public Transform bolacoiso;
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
            Instantiate(bola, bola.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("explo"))
        {
           bolaColission = Physics2D.OverlapCircle(bolacoiso.position, 1);

            if(bolaColission != null)
            {
                if(bolaColission.CompareTag("plat"))
                {
                    Destroy(bolaColission.gameObject);
                }
            }
        }
    }
}
