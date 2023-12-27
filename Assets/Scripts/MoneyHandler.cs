using TMPro;
using UnityEngine;

public class MoneyHandler : MonoBehaviour
{
    public static int MoneyCount = 0; //Int32.MaxValue;
    [SerializeField] private TextMeshProUGUI moneyCountText;
    [SerializeField] private TextMeshProUGUI moneyCountShopText;
    private void Update()
    {
        moneyCountText.text = MoneyCount + "<color=#02c405>$</color>";
        moneyCountShopText.text = MoneyCount + "<color=#02c405>$</color>";
    }
}
