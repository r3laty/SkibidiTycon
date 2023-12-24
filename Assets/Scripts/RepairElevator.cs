using UnityEngine;

public class RepairElevator : MonoBehaviour
{
    [SerializeField] private Sprite repairedElevatorSprite;
    [SerializeField] private SpriteRenderer elevatorSpriteRenderer;
    [SerializeField] private int fixPrice = 100000;
    public void OnRepairButtonClick()
    {
        elevatorSpriteRenderer.sprite = repairedElevatorSprite;
        MoneyHandler.MoneyCount -= fixPrice;
    }
}
