using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class AdsProvider : MonoBehaviour
{
    [SerializeField] private float effectDuration = 60;
    [SerializeField] private float timeForRevard = 2;
    [SerializeField] private Button speedupTimeButton;
    [SerializeField] private TextMeshProUGUI adTimer;
    private float _fullscreenAdInterval = 60;
    private void Start()
    {
        speedupTimeButton.interactable = false;
    }

    //private void Update()
    //{
    //    _timerShowAd += Time.unscaledDeltaTime;
    //    if (_timerShowAd <= _fullscreenAdInterval)
    //    {
    //        adTimer.gameObject.SetActive(true);
    //        adTimer.text = $"{(_fullscreenAdInterval - _timerShowAd).ToString("00")} сек.";
    //    }
    //    else
    //    {
    //        speedupTimeButton.interactable = true;
    //        adTimer.gameObject.SetActive(false);
    //    }

    //}
    private void Update()
    {
        adTimer.text = $"{(_fullscreenAdInterval - YandexGame.timerShowAd).ToString("00")} сек.";
        if (YandexGame.timerShowAd >= _fullscreenAdInterval)
        {
            speedupTimeButton.interactable = true;
        }
    }

    ///method on button
    public void WatchAdvertisment()
    {
        if (YandexGame.timerShowAd >= _fullscreenAdInterval)
        {
            YG.YandexGame.FullscreenShow();
            StartCoroutine(MultplyTime());
        }
    }
    public IEnumerator MultipyTimeRewardTimer()
    {
        YandexGame.FullscreenShow();
        Time.timeScale = timeForRevard;
        yield return new WaitForSeconds(effectDuration);
        Time.timeScale = 1;
    }

    public void OnExitButtonClick()
    {
        speedupTimeButton.interactable = false;
    }
    private IEnumerator MultplyTime()
    {
        Time.timeScale = timeForRevard;
        print("Time scaled");
        yield return new WaitForSeconds(effectDuration);
        Time.timeScale = 1;
    }
}
