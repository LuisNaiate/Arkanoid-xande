using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using UnityEngine.SceneManagement;

public class detectarBola : MonoBehaviour
{

    public TextMeshProUGUI numeroText;
    public int numeroRegressivo = 3;
    int segundo = 1;
    float timer;

    void Start()
    {
        if (SceneManager.GetActiveScene().name != "Menu" && podeComeca.comeca == true)
        {
            podeComeca.comeca = false;
            
        }
    }


    void Update()

    {

        timer += Time.deltaTime;
        numeroText.text = numeroRegressivo.ToString();
        if (timer >= segundo)

        {

            numeroRegressivo -= 1;

            timer = 0f;

            numeroText.text = numeroRegressivo.ToString();

        }

        if (numeroRegressivo <= 0)

        {

            numeroText.text = "";

            numeroRegressivo = 0;

            podeComeca.comeca = true;

        }

    }

}

public static class podeComeca

{

    public static bool comeca = false;

}

