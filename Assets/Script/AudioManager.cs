using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private float globalVolume = 1.0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    public void PlaySound(AudioClip sound)
    {

    }

    public void SetGlobalVolume(float volume)
    {
        globalVolume = Mathf.Clamp01(volume);
        AudioListener.volume = globalVolume;
    }
}
