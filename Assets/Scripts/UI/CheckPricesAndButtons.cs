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
    [Header("Elevator")]
    [SerializeField] private Button elevatorButton;
    [SerializeField] private int elevatorPrice;


    private void Start()
    {
        button2.enabled = false;
        button3.enabled = false;
        button4.enabled = false;
        button5.enabled = false;
        button6.enabled = false;

        shopButton.enabled = false;
        elevatorButton.enabled = false;
    }
    private void Update()
    {
        CheckPrice(buttonPrice2, button2);
        CheckPrice(buttonPrice3, button3);
        CheckPrice(buttonPrice4, button4);
        CheckPrice(buttonPrice5, button5);
        CheckPrice(buttonPrice6, button6);

        CheckPrice(shopPrice, shopButton);
        CheckPrice(elevatorPrice, elevatorButton);
    }
    private void CheckPrice(int price, Button button)
    {
        if (MoneyHandler.MoneyCount >= price)
        {
            button.enabled = true;
        }
        else
        {
            button.enabled = false;
        }
    }

}
