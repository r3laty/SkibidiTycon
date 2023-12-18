using UnityEngine;

public class AssighSkin : MonoBehaviour
{
    [SerializeField] private string typeOfAmogus;
    [Space]
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Update()
    {
        SetSprite();
    }
    public void SetSprite()
    {
        if (typeOfAmogus == "red" && SkinControll.buttonId == 0)
        {
            spriteRenderer.sprite = SkinControll.Instance.SkinItem();
        }
        if (typeOfAmogus == "blue" && SkinControll.buttonId == 1)
        {
            spriteRenderer.sprite = SkinControll.Instance.SkinItem();
        }
        if (typeOfAmogus == "purple" && SkinControll.buttonId == 2)
        {
            spriteRenderer.sprite = SkinControll.Instance.SkinItem();
        }
        if (typeOfAmogus == "green" && SkinControll.buttonId == 3)
        {
            spriteRenderer.sprite = SkinControll.Instance.SkinItem();
        }
        if (typeOfAmogus == "yellow" && SkinControll.buttonId == 4)
        {
            spriteRenderer.sprite = SkinControll.Instance.SkinItem();
        }
        if (typeOfAmogus == "white" && SkinControll.buttonId == 5)
        {
            spriteRenderer.sprite = SkinControll.Instance.SkinItem();
        }
    }
}
