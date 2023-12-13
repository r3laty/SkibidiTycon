using UnityEngine;

public class ToiletManager : MonoBehaviour
{
    [SerializeField] private GameObject toiletPrefab;
    [SerializeField] private Transform[] spawnPoints = new Transform[4];

    [SerializeField] private AmogusManager amogusManager;

    private int _activeToilets = 1;
    private bool _allDestroyed;

    private Vector3 _currentPosition;
    private Vector3 _nextToiletPosition;

    private void Start()
    {
        _currentPosition = transform.position;
    }
    private void Update()
    {
        SpawnToilets();
    }
    public void ToiletRemoved()
    {
        _activeToilets--;

        if (_activeToilets == 0)
        {
            _allDestroyed = true;
        }
    }

    private void SpawnToilets()
    {
        if (_allDestroyed)
        {
            GameObject newToilet = Instantiate(toiletPrefab, transform.position, Quaternion.identity);
            _activeToilets++;

            if (amogusManager.pressCount == 2)
            {
                Vector3 toilet2Position = spawnPoints[0].position;
                GameObject newToilet2 = Instantiate(toiletPrefab, toilet2Position, Quaternion.identity);
                _activeToilets++;
            }
            if (amogusManager.pressCount == 3)
            {
                Vector3 toilet2Position = spawnPoints[0].position;
                GameObject newToilet2 = Instantiate(toiletPrefab, toilet2Position, Quaternion.identity);

                Vector3 toilet3Position = spawnPoints[1].position;
                GameObject newToilet3 = Instantiate(toiletPrefab, toilet3Position, Quaternion.identity);
                _activeToilets += 2;
            }
            if (amogusManager.pressCount == 4)
            {
                Vector3 toilet2Position = spawnPoints[0].position;
                GameObject newToilet2 = Instantiate(toiletPrefab, toilet2Position, Quaternion.identity);

                Vector3 toilet3Position = spawnPoints[1].position;
                GameObject newToilet3 = Instantiate(toiletPrefab, toilet3Position, Quaternion.identity);

                Vector3 toilet4Position = spawnPoints[2].position;
                GameObject newToilet4 = Instantiate(toiletPrefab, toilet4Position, Quaternion.identity);
                _activeToilets += 3;
            }
            if (amogusManager.pressCount == 5)
            {
                Vector3 toilet2Position = spawnPoints[0].position;
                GameObject newToilet2 = Instantiate(toiletPrefab, toilet2Position, Quaternion.identity);

                Vector3 toilet3Position = spawnPoints[1].position;
                GameObject newToilet3 = Instantiate(toiletPrefab, toilet3Position, Quaternion.identity);

                Vector3 toilet4Position = spawnPoints[2].position;
                GameObject newToilet4 = Instantiate(toiletPrefab, toilet4Position, Quaternion.identity);


                Vector3 toilet5Position = spawnPoints[3].position;
                GameObject newToilet5 = Instantiate(toiletPrefab, toilet5Position, Quaternion.identity);
                _activeToilets += 4;
            }
            _allDestroyed = false;
        }
    }
}
