using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class SoundManager : MonoBehaviour
{

    [SerializeField] Slider SFXSlider;
    [SerializeField] Slider musicSlider;
    [SerializeField] AudioMixer myMixer;
    // Start is called before the first frame update
     void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
        }
        DontDestroyOnLoad(GameObject.FindGameObjectWithTag("Audio"));
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }
    public void SetSFXVolume()
    {
        float volume = SFXSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }
    public void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        SetMusicVolume();
    }
    void Update()
    {
        
    }
}
