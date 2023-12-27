using System.Collections;
using TMPro;
using UnityEngine;
using YG;

public class AdsProvider : MonoBehaviour
{
    [SerializeField] private float multiplierOfTime = 3;
    [SerializeField] private float effectDuration = 60;
    [SerializeField] private TextMeshProUGUI adExeption;
    private float _timerShowAd;
    private float _fullscreenAdInterval = 60;

    private void Update()
    {
        _timerShowAd += Time.unscaledDeltaTime;
    }

    ///method on button
    public void WatchAdvertisment()
    {
        if (_timerShowAd >= _fullscreenAdInterval)
        {
            YG.YandexGame.FullscreenShow();
            StartCoroutine(multplyTime());
        }
        else
        {
            adExeption.gameObject.SetActive(true);
            adExeption.text = $"ƒо запроса к показу рекламы в середине игры {(_fullscreenAdInterval - _timerShowAd).ToString("00")} сек.";
            StartCoroutine(CloseExeption());
        }
    }

    public void OnExitButtonClick()
    {
        StopAllCoroutines();
    }
    private IEnumerator multplyTime()
    {
        Time.timeScale = multiplierOfTime;
        yield return new WaitForSeconds(effectDuration);
        Time.timeScale = 1;
    }
    private IEnumerator CloseExeption()
    {
        yield return new WaitForSeconds(2);
        adExeption.gameObject.SetActive(false);
    }
}
