using TMPro;
using UnityEngine;

public class MoneyHandler : MonoBehaviour
{
    public static int MoneyCount = 0;
    [SerializeField] private TextMeshProUGUI moneyCountText;
    private void Update()
    {
        moneyCountText.text = MoneyCount + "<color=#02c405>$</color>";
    }
}
