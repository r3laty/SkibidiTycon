using UnityEngine;

public class FacroryController : MonoBehaviour
{
    [SerializeField] private GameObject amogusPrefab;
    [SerializeField] private Transform spawnArea;
    [SerializeField] private int[] prices = new int[4];

    private Vector2 _needPosition;
    private Vector2 _currentPosition;
    
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
        float checkDistance = Vector3.Distance(_needPosition, _currentPosition);

        Vector3 newAmogusSpawnArea = new Vector3(-checkDistance, 0, 0);

        Instantiate(amogusPrefab, spawnArea.position, Quaternion.identity);
        spawnArea.position -= new Vector3(-newAmogusSpawnArea.x, 0, 0);
    }
}
