using UnityEngine;

public class ToiletManager : MonoBehaviour
{
    [SerializeField] private GameObject toiletPrefab;
    [SerializeField] private Transform[] spawnPoints = new Transform[4];

    [SerializeField] private AmogusManager amogusManager;

    private int _countOfClick;
    private int _maximumToilets;
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
            _countOfClick = 0;
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

            //{
            //    float checkDistance = Vector3.Distance(_nextToiletPosition, _currentPosition);
            //    Vector3 nextToiletPosition2 = new Vector3(-checkDistance, 0, 0);
            //    spawnArea.position -= new Vector3(_currentPosition.x - 1, _currentPosition.y, _currentPosition.z);

            //    GameObject newToilet3 = Instantiate(toiletPrefab, nextToiletPosition2, Quaternion.identity);
            //    _activeToilets++;
            //}

            //for (int i = 0; i <= _maximumToilets; i++)
            //{
            //    switch (amogusManager.pressCount)
            //    {
            //        case 1:
            //            GameObject newToilet = Instantiate(toiletPrefab, transform.position, Quaternion.identity);
            //            _activeToilets++;
            //            break;
            //        case 2:
            //            GameObject newToilet2 = Instantiate(toiletPrefab, _nextToiletPosition, Quaternion.identity);
            //            _activeToilets++;
            //            break;
            //        case 3:
            //            print("case 3");
            //            break;
            //        case 4:
            //            print("case 4");
            //            break;
            //        case 5:
            //            print("case 5");
            //            break;


            //        default:
            //            print("Default");
            //            break;
            //    }
            //}

            _allDestroyed = false;
        }

        //for (int i = 1; i == _activeToilets; i++)
        //{
        //    float checkDistance = Vector3.Distance(_nextToiletPosition, _currentPosition);
        //    Vector3 newToiletSpawnArea = new Vector3(-checkDistance, 0, 0);
        //    GameObject newToilet = Instantiate(toiletPrefab, spawnArea.position, Quaternion.identity);
        //    spawnArea.position -= new Vector3(-newToiletSpawnArea.x, 0, 0);

        //}

        //for (int i = 0; i >= amogusManager.pressCount; i++)
        //{
        //    float checkDistance = Vector3.Distance(_nextToiletPosition, _currentPosition);
        //    Vector3 newToiletSpawnArea = new Vector3(-checkDistance, 0, 0);
        //    GameObject newToilet = Instantiate(toiletPrefab, spawnArea.position, Quaternion.identity);
        //    spawnArea.position -= new Vector3(-newToiletSpawnArea.x, 0, 0);

        //    _activeToilets++;
        //}
    }
}
