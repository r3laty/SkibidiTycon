using UnityEngine;

public class ElevatorWork : MonoBehaviour
{
    [SerializeField] private Transform mainCamera;

    private Vector3 _secondFloor = new Vector3(23, 0, -10);
    private Vector3 _firstFloor = new Vector3(0, 0, -10);
    public void GoToSecondFloor()
    {
        mainCamera.transform.position = _secondFloor;   
    }
    public void GoToFirstFloor()
    {
        mainCamera.transform.position = _firstFloor;   
    }
}
