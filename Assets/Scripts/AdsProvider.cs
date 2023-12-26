using System.Collections;
using UnityEngine;

public class AdsProvider : MonoBehaviour
{
    [SerializeField] private float multiplierOfTime = 2;
    [SerializeField] private float effectDuration = 25;
    
    ///method on button
    public void WatchAdvertisment()
    {
        YG.YandexGame.FullscreenShow();
        StartCoroutine(multplyTime());
    }
    private IEnumerator multplyTime()
    {
        Time.timeScale = multiplierOfTime;
        yield return new WaitForSeconds(effectDuration);
        Time.timeScale = 1;
    }
}
