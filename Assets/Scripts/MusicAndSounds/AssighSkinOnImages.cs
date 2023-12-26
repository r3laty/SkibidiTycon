using UnityEngine;
using UnityEngine.UI;

public class AssighSkinOnImages : MonoBehaviour
{
    public AmogusColor colorOfAmogus;
    [SerializeField] private int colorIndex = 100;
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

        if (_red && SkinControll.buttonId == 0)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

        if (_blue && SkinControll.buttonId == 1)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

        if (_purple && SkinControll.buttonId == 2)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

        if (_green && SkinControll.buttonId == 3)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

        if (_yellow && SkinControll.buttonId == 4)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

        if (_white && SkinControll.buttonId == 5)
        {
            source.sprite = SkinControll.Instance.SkinItem();
            source.color = _newColor;
        }

    }
}