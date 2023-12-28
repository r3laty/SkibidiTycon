using UnityEngine;

public class RepairObject : MonoBehaviour
{
    [SerializeField] private Sprite repairedSprite;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private int fixPrice = 100000;
    [Space]
    [SerializeField] private MusicSettings sound;
    public void OnRepairButtonClick()
    {
        if (MoneyHandler.MoneyCount >= fixPrice)
        {
            spriteRenderer.sprite = repairedSprite;
            MoneyHandler.MoneyCount -= fixPrice;
            sound.FixSound.Play();
        }
        else
        {
            sound.BuyFailSound.Play();  
        }
    }

}
