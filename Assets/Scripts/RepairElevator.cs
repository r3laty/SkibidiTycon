using UnityEngine;

public class RepairElevator : MonoBehaviour
{
    [SerializeField] private Sprite repairedElevatorSprite;
    [SerializeField] private SpriteRenderer elevatorSpriteRenderer;
    public void OnRepairButtonClick()
    {
        elevatorSpriteRenderer.sprite = repairedElevatorSprite;
    }
}
