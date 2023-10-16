using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Button button;
    public AudioClip son;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        button.onClick.AddListener(JouerSon);
    }

    void JouerSon()
    {
        source.PlayOneShot(son);
    }
}
