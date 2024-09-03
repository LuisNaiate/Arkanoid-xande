using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodir : MonoBehaviour
{
    
    public static bool taAtivo = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (taAtivo)
        {
            if (collision.gameObject.CompareTag("plat"))
            {
                Destroy(collision.gameObject);
                gameObject.SetActive(false);
                taAtivo = false ;
            }
        }
       
    }
}
