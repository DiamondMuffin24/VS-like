using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumecode : MonoBehaviour
{
    
  
    public AudioSource audioSource;
    public Slider volumeSlider;

    void Start()
    {
        // Set the initial volume value of the slider to match the AudioSource volume
        volumeSlider.value = audioSource.volume;

        // Add a listener to the slider to call a method when the value changes
        volumeSlider.onValueChanged.AddListener(delegate { OnVolumeChanged(); });
    }

    void OnVolumeChanged()
    {
        // Set the volume of the AudioSource to match the value of the slider
        audioSource.volume = volumeSlider.value;
    }
}
