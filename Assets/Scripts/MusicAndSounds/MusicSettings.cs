using UnityEngine;
using UnityEngine.UI;

public class MusicSettings : MonoBehaviour
{
    [Header("Music")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private Slider musicSettingsSlider;
    [Header("Sounds")]
    [SerializeField] private Slider soundsSettingsSlider;

    public AudioSource AddMoneySound;
    public AudioSource BuyFailSound;
    public AudioSource BuySuccessSound;
    public AudioSource CheckSound;
    public AudioSource FixSound;
    public AudioSource ShopOpenAndCloseSound;

    private AudioSource[] _allSounds = new AudioSource[6];
    private float _musicAndSoundsVolume = 0.5f;
    private void Awake()
    {
        _allSounds[0] = AddMoneySound;
        _allSounds[1] = BuyFailSound;
        _allSounds[2] = BuySuccessSound;
        _allSounds[3] = CheckSound;
        _allSounds[4] = FixSound;
        _allSounds[5] = ShopOpenAndCloseSound;
    }
    private void Start()
    {
        musicSettingsSlider.value = _musicAndSoundsVolume;

        //soundsSettingsSlider.value = _musicAndSoundsVolume;
    }
    private void Update()
    {
        musicSource.volume = musicSettingsSlider.value; 
    }
}
