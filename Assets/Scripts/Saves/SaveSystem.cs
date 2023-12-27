using System.Collections;
using UnityEngine;
using YG;

public class SaveSystem : MonoBehaviour
{
    [SerializeField] private float autoSaveDelay = 15;
    [SerializeField] private Sprite newYearSkin;
    [SerializeField] private Sprite floorSkin;
    [SerializeField] private Sprite currentGun;
    [SerializeField] private Sprite currentSkin;
    private void Start()
    {
        StartCoroutine(AutoSave());

        if (YandexGame.SDKEnabled == true)
        {
            LoadSaveCloud();
        }
    }
    public void SaveData()
    {
        YandexGame.savesData.SkibidiMoney = MoneyHandler.MoneyCount;
        YandexGame.savesData.NewYearSkin = newYearSkin;
        YandexGame.savesData.FloorSkin = floorSkin;
        YandexGame.savesData.CurrentGun = currentGun;
        YandexGame.savesData.CurrentSkin = currentSkin;
        YandexGame.SaveProgress();
    }
    private IEnumerator AutoSave()
    {
        while (true)
        {
            SaveData();
            yield return new WaitForSeconds(autoSaveDelay);
        }
    }
    private void LoadSaveCloud()
    {
        MoneyHandler.MoneyCount = YandexGame.savesData.SkibidiMoney;
        newYearSkin = YandexGame.savesData.NewYearSkin;
        floorSkin = YandexGame.savesData.FloorSkin;
        currentGun = YandexGame.savesData.CurrentGun;
        currentSkin = YandexGame.savesData.CurrentSkin;
    }
}
