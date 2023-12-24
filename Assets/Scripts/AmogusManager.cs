using TMPro;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

public class AmogusManager : MonoBehaviour
{
    [HideInInspector] public int pressCount = 1;

    [SerializeField] private GameObject amogusPrefab;

    [SerializeField] private Transform spawnArea;
    [SerializeField] private Button spawnButton;

    [SerializeField] private int[] prices = new int[4];

    [SerializeField] private float distance = -1.533733f;

    private RectTransform _buttonRect;
    private TextMeshProUGUI _buttonText;
    private int _currentPrice;
    private int _price;
    private int _priceIndex = 1;

    private string _dollar = "<color=#02c405>$</color>";
    private void Awake()
    {
        _buttonRect = spawnButton.GetComponent<RectTransform>();
        _buttonText = spawnButton.GetComponentInChildren<TextMeshProUGUI>();
    }

    /// <summary>
    /// Method on button
    /// </summary>
    public void SpawnNewAmogus()
    {
        if (MoneyHandler.MoneyCount >= prices[_currentPrice])
        {
            if (_priceIndex < prices.Length)
            {
                _price = prices[_priceIndex];
                _buttonText.text = _price.ToString() + _dollar;

                Vector3 newAmogusSpawnArea = new Vector3(distance, 0, 0);

                Instantiate(amogusPrefab, spawnArea.position, Quaternion.identity);
                spawnArea.position -= new Vector3(-newAmogusSpawnArea.x, 0, 0);
                _buttonRect.anchoredPosition -= new Vector2(_buttonRect.sizeDelta.x, 0f);

                MoneyHandler.MoneyCount -= prices[_currentPrice];

                _priceIndex++;

                pressCount++;
            }
            else
            {
                int lastpriceElement = prices[prices.Length - 1];
                _price = lastpriceElement;
                Instantiate(amogusPrefab, spawnArea.position, Quaternion.identity);
                MoneyHandler.MoneyCount -= _price;

                print("Last button touch");

                pressCount++;

                Destroy(spawnButton.gameObject);
            }
            _currentPrice++;
        }
        else
        {
            Debug.Log("Not enought money");
        }
    }
}
