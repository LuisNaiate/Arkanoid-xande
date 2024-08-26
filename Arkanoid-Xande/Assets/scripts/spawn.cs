using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawn : MonoBehaviour
{
   
    public Transform[] spawns;
    public GameObject[] blocos;

    private void Start()
    {
        spawnss(4);
    }
    void spawnss(int qtd)
    {

        float px= -12f;
        float py = 6.4f;

        for (int i = 0; i < 4; i++)
        {
            px = -12f;
            for (int j = 0; j < 13; j++)
            {
                Vector2 pos = new Vector2(px, py);
                Instantiate(blocos[i], pos, Quaternion.identity);
                px += 2;
            }
            py -= 0.5f ;
        }
    }
}
