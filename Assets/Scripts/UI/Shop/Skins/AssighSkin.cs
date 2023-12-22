using UnityEngine;

public class AssighSkin : MonoBehaviour
{
    public AmogusColor colorOfAmogus;
    [Space]
    [SerializeField] private SpriteRenderer spriteRenderer;

    private bool _red;
    private bool _blue;
    private bool _purple;
    private bool _green;
    private bool _yellow;
    private bool _white;

    private void Update()
    {
        SetSprite();
    }
    private void ChooseColor()
    {
        switch (colorOfAmogus)
        {
            case AmogusColor.Red:
                _red = true;
                break;
            case AmogusColor.Blue:
                _blue = true;
                break;
            case AmogusColor.Purple:
                _purple = true;
                break;
            case AmogusColor.Green:
                _green = true;
                break;
            case AmogusColor.Yellow:
                _yellow = true;
                break;
            case AmogusColor.White:
                _white = true;
                break;
            default:
                break;
        }

    }
    private void SetSprite()
    {

        if (_red && SkinControll.buttonId == 0) spriteRenderer.sprite = SkinControll.Instance.SkinItem();

        if (_blue && SkinControll.buttonId == 1) spriteRenderer.sprite = SkinControll.Instance.SkinItem();

        if (_purple && SkinControll.buttonId == 2) spriteRenderer.sprite = SkinControll.Instance.SkinItem();

        if (_green && SkinControll.buttonId == 3) spriteRenderer.sprite = SkinControll.Instance.SkinItem();

        if (_yellow && SkinControll.buttonId == 4) spriteRenderer.sprite = SkinControll.Instance.SkinItem();

        if (_white && SkinControll.buttonId == 5) spriteRenderer.sprite = SkinControll.Instance.SkinItem();
    }

}

public enum AmogusColor
{
    Red,
    Blue,
    Purple,
    Green,
    Yellow,
    White
}