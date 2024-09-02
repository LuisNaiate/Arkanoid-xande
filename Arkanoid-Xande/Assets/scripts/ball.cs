using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    [Header("coiso")]

    [SerializeField] private float speed = 30;
    [SerializeField] Rigidbody2D rb;

    [Header("power ups")]

    public GameObject doublee, explod, aumentar;

    [Header("não coiso")]

    public GameObject fim;
    public string cena;

    

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == fim)
        {
            SceneManager.LoadSceneAsync(cena);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "racket")
        {
            float x = HitFactor(transform.position,
                collision.transform.position,
                collision.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;


            rb.velocity = dir * speed;
        }

        if(collision.gameObject.CompareTag("plat"))
        {

            int random = 0;
            random = Random.Range(0, 15);
            if (random == 4)
            {
                Instantiate(doublee);
            }
            if(random == 8)
            {
                Instantiate(explod);
            }
            if(random == 13)
            {
                Instantiate(aumentar);
            }
            Destroy(collision.gameObject);
            
        }

    }
}
