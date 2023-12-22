using UnityEngine;
using UnityEngine.UI;

public class AssighSkinOnImages : MonoBehaviour
{
    public AmogusColor colorOfAmogus;
    [Space]
    [SerializeField] private Image source;

    private bool _red;
    private bool _blue;
    private bool _purple;
    private bool _green;
    private bool _yellow;
    private bool _white;

    private Color _newColor;
    private void Awake()
    {
        _newColor = source.color;
        _newColor.a = 0xFF;
    }
    private void Update()
    {
        SetImage();
    }
    private void SetImage()
    {
        switch (colorOfAmogus)
        {
            case AmogusColor.Red:
                _red = true;
                print("Red amogus");
                break;
            case AmogusColor.Blue:
                _blue = true;
                print("Blue amogus");
                break;
            case AmogusColor.Purple:
                _purple = true;
                print("Purple amogus");
                break;
            case AmogusColor.Green:
                _green = true;
                print("Green amogus");
                break;
            case AmogusColor.Yellow:
                _yellow = true;
                print("Yellow amogus");
                break;
            case AmogusColor.White:
                _white = true;
                print("White amogus");
                break;
            default:
                break;
        }

        if (_red && SkinControll.buttonId == 0)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

        if (_blue && SkinControll.buttonId == 0)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

        if (_purple && SkinControll.buttonId == 0)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

        if (_green && SkinControll.buttonId == 0)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

        if (_yellow && SkinControll.buttonId == 0)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

        if (_white && SkinControll.buttonId == 0)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

    }
}