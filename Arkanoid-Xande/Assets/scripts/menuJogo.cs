using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuJogo : MonoBehaviour
{

  
    public GameObject menu;
    public AudioMixer AudioMixer;
   
    
   
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
          menu.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }

    public void Sair()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Voltar()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void SetVolume(float volume)
    {
        AudioMixer.SetFloat("Master", volume);
    }

}
