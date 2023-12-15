using UnityEngine;

public class AssighSkin : MonoBehaviour
{
    [SerializeField] private SkinColor skinColor;
    [Space]
    [SerializeField] private Sprite defaultSprite_red;
    [SerializeField] private Sprite defaultSprite_blue;
    [SerializeField] private Sprite defaultSprite_purple;
    [SerializeField] private Sprite defaultSprite_green;
    [SerializeField] private Sprite defaultSprite_yellow;
    [SerializeField] private Sprite defaultSprite_white;
    [Space]
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Update()
    {
        SetSprite();
    }
    private void SetSprite()
    {
        switch (skinColor)
        {
            case SkinColor.Red:
                spriteRenderer.sprite = SkinControll.Instance.SkinItem();
                Debug.Log("Changed skin " + SkinControll.Instance.SkinItem().name);
                break;
            case SkinColor.Blue:
                print("blue");
                break;
            case SkinColor.Purple:
                spriteRenderer.sprite = SkinControll.Instance.SkinItem();
                break;
            case SkinColor.Green:
                spriteRenderer.sprite = SkinControll.Instance.SkinItem();
                break;
            case SkinColor.Yellow:
                spriteRenderer.sprite = SkinControll.Instance.SkinItem();
                break;
            case SkinColor.White:
                spriteRenderer.sprite = SkinControll.Instance.SkinItem();
                break;
            default: print("Non skin wasnt set");
                break;
        }
    }
}
public enum SkinColor
{
    Red,
    Blue,
    Purple,
    Green,
    Yellow,
    White
}