using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
   public AudioMixer AudioMixer;
   public void Jogar()
    {
        SceneManager.LoadScene("fase");
    } 


    public void Sair()
    {
        Application.Quit();
    }
    public void SetVolume(float volume)
    {
        AudioMixer.SetFloat("Master", volume);
    }
}
