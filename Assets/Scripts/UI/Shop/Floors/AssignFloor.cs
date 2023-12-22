using UnityEngine;

public class AssignFloor : MonoBehaviour
{
    [SerializeField] private GameObject[] chessFloor;
    [Space]
    [SerializeField] private GameObject[] ironFloor;
    [Space]
    [SerializeField] private GameObject[] goldenFloor;    
    private void Update()
    {
        SetSprite();
    }
    private void SetSprite()
    {
        if (FloorControll.buttonId == 1)
        {
            chessFloor[0].SetActive(true);
            chessFloor[1].SetActive(true);
        }
        if (FloorControll.buttonId == 2)
        {
            chessFloor[0].SetActive(false);
            chessFloor[1].SetActive(false);

            ironFloor[0].SetActive(true);
            ironFloor[1].SetActive(true);
        }
        if (FloorControll.buttonId == 3)
        {
            chessFloor[0].SetActive(false);
            chessFloor[1].SetActive(false);

            ironFloor[0].SetActive(false);
            ironFloor[1].SetActive(false);

            goldenFloor[0].SetActive(true);
            goldenFloor[1].SetActive(true);
        }
    }

}
