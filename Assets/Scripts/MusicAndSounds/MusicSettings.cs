using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSettings : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private Slider musicSettingsSlider;
    private void Start()
    {
        musicSettingsSlider.value = musicSource.volume;
    }
    private void Update()
    {
        musicSource.volume = musicSettingsSlider.value;
    }
}
