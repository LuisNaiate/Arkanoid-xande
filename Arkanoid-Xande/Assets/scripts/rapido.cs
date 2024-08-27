using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rapido : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;


    void Start()
    {
        if (!PlayerPrefs.HasKey("Master"))
        {
            PlayerPrefs.SetFloat("Master", 1);
            Load();
        }
        else
        {
            Load();
        }


    }

    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        save();
    }

    public void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Master");
    }

    public void save()
    {
        PlayerPrefs.SetFloat("Master", volumeSlider.value);
    }
}
