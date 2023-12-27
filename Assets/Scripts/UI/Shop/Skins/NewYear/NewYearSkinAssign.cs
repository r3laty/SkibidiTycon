using UnityEngine;

public class NewYearSkinAssign : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] allSpriteRenderersOfAmogus;
    private void Update()
    {
        SetSprite();
    }
    private void SetSprite()
    {
        print("Method is working");
        if (NewYearSkinControll.buttonId == 0)
        {
            foreach (var renderer in allSpriteRenderersOfAmogus)
            {
                renderer.sprite = NewYearSkinControll.Instance.SkinItem();
            }
            Debug.Log(NewYearSkinControll.Instance.SkinItem().name);
        }

        if (NewYearSkinControll.buttonId == 1)
        {
            foreach (var renderer in allSpriteRenderersOfAmogus)
            {
                renderer.sprite = NewYearSkinControll.Instance.SkinItem();
            }
            Debug.Log(NewYearSkinControll.Instance.SkinItem().name);
        }

        if (NewYearSkinControll.buttonId == 2)
        {
            foreach (var renderer in allSpriteRenderersOfAmogus)
            {
                renderer.sprite = NewYearSkinControll.Instance.SkinItem();
            }
            Debug.Log(NewYearSkinControll.Instance.SkinItem().name);
        }

        if (NewYearSkinControll.buttonId == 3)
        {
            foreach (var renderer in allSpriteRenderersOfAmogus)
            {
                renderer.sprite = NewYearSkinControll.Instance.SkinItem();
            }
            Debug.Log(NewYearSkinControll.Instance.SkinItem().name);
        }

        if (NewYearSkinControll.buttonId == 4)
        {
            foreach (var renderer in allSpriteRenderersOfAmogus)
            {
                renderer.sprite = NewYearSkinControll.Instance.SkinItem();
            }
            Debug.Log(NewYearSkinControll.Instance.SkinItem().name);
        }

        if (NewYearSkinControll.buttonId == 5)
        {
            foreach (var renderer in allSpriteRenderersOfAmogus)
            {
                renderer.sprite = NewYearSkinControll.Instance.SkinItem();
            }
            Debug.Log(NewYearSkinControll.Instance.SkinItem().name);
        }

    }

}
