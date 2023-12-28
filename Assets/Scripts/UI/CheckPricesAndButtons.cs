using UnityEngine;
using UnityEngine.UI;

public class CheckPricesAndButtons : MonoBehaviour
{
    [Header("SecondFactoryFirstFloor")]
    [SerializeField] private Button button2;
    [SerializeField] private int buttonPrice2;
    [Space]
    [Header("ThirdFactoryFirstFloor")]
    [SerializeField] private Button button3;
    [SerializeField] private int buttonPrice3;
    [Space]
    [Header("FirstFactorySecondFloor")]
    [SerializeField] private Button button4;
    [SerializeField] private int buttonPrice4;
    [Space]
    [Header("SecondFactorySecondFloor")]
    [SerializeField] private Button button5;
    [SerializeField] private int buttonPrice5;
    [Space]
    [Header("ThirdtFactorySecondFloor")]
    [SerializeField] private Button button6;
    [SerializeField] private int buttonPrice6;
    [Space]
    [Header("Shop")]
    [SerializeField] private Button shopButton;
    [SerializeField] private int shopPrice;
    [Space]
    [SerializeField] private MusicSettings sound;
    public void Payment(int buttonPrice)
    {
        if (MoneyHandler.MoneyCount >= buttonPrice)
        {
            MoneyHandler.MoneyCount -= buttonPrice;
            sound.BuySuccessSound.Play();
        }
        else
        {
            sound.BuyFailSound.Play();

        }
    }

}
