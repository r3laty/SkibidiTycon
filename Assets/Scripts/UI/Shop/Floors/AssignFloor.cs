using UnityEngine;

public class AssignFloor : MonoBehaviour
{
    [SerializeField] private GameObject[] chessFloor;
    [Space]
    [SerializeField] private GameObject[] ironFloor;
    [Space]
    [SerializeField] private GameObject[] goldenFloor;
    [Space]
    [SerializeField] private GameObject[] defaultFloor;
    private void Update()
    {
        SetSprite();
    }
    private void SetSprite()
    {
        if (FloorControll.buttonId == 1)
        {
            defaultFloor[0].SetActive(false);
            defaultFloor[1].SetActive(false);

            ironFloor[0].SetActive(false);
            ironFloor[1].SetActive(false);

            goldenFloor[0].SetActive(false);
            goldenFloor[1].SetActive(false);

            chessFloor[0].SetActive(true);
            chessFloor[1].SetActive(true);
        }
        if (FloorControll.buttonId == 2)
        {
            defaultFloor[0].SetActive(false);
            defaultFloor[1].SetActive(false);

            goldenFloor[0].SetActive(false);
            goldenFloor[1].SetActive(false);

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
