using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource musicSource;

    public void SetVolume()
    {
        float volume = volumeSlider.value;
        musicSource.volume = volume;    
    }
}
