using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimentação : MonoBehaviour
{
    [Header("corpo")]

    float horizontal;
     private Rigidbody2D body;
    private int speed = 22;
    Collider2D bolaColission;

    [Header("outros gameObjects")]

    public GameObject bola;
    
    public int qtdBolas;
   
    


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        qtdBolas = 1;
       
       
      
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);

        if (qtdBolas <= 0)
        {
            SceneManager.LoadScene("fase");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("double"))
        {
            Instantiate(bola, bola.transform.position, Quaternion.identity);
            qtdBolas++;
            Destroy(collision.gameObject);
        }

        if(bola.gameObject.CompareTag("fim"))
        {
            qtdBolas--;
        }
        if(collision.gameObject.CompareTag("explo"))
        {

            explodir.taAtivo = true;
            
        }

        if(collision.gameObject.CompareTag("aumentar"))
        {
           
        }
    }

   
}
