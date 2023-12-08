using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FacroryController : MonoBehaviour
{
    [SerializeField] private GameObject amogusPrefab;

    [SerializeField] private Transform spawnArea;
    [SerializeField] private Button spawnButton;

    [SerializeField] private int[] prices = new int[4];

    private Vector2 _needPosition;
    private Vector2 _currentPosition;

    private RectTransform _buttonRect;
    private TextMeshProUGUI _buttonText;
    private int _price;
    private int _priceIndex = 1;

    private string _dollar = "<color=#02c405>$</color>";
    private void Awake()
    {
        _buttonRect = spawnButton.GetComponent<RectTransform>();
        _buttonText = spawnButton.GetComponentInChildren<TextMeshProUGUI>();

    }
    private void Start()
    {
        _currentPosition = transform.position;
        _needPosition = spawnArea.position;
    }
    /// <summary>
    /// Method on button
    /// </summary>
    public void SpawnNewAmogus()
    {
        if (_priceIndex < prices.Length)
        {
            _price = prices[_priceIndex];
            _buttonText.text = _price.ToString() + _dollar;

            float checkDistance = Vector3.Distance(_needPosition, _currentPosition);

            Vector3 newAmogusSpawnArea = new Vector3(-checkDistance, 0, 0);

            Instantiate(amogusPrefab, spawnArea.position, Quaternion.identity);
            spawnArea.position -= new Vector3(-newAmogusSpawnArea.x, 0, 0);
            _buttonRect.anchoredPosition -= new Vector2(_buttonRect.sizeDelta.x, 0f);

            _priceIndex++;
        }
        else
        {
            float checkDistance = Vector3.Distance(_needPosition, _currentPosition);

            Vector3 newAmogusSpawnArea = new Vector3(-checkDistance, 0, 0);

            Instantiate(amogusPrefab, spawnArea.position, Quaternion.identity);

            Destroy(spawnButton.gameObject);
        }

    }
}
