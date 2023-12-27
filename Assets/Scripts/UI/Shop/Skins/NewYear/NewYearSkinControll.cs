using UnityEngine;

public class NewYearSkinControll : MonoBehaviour
{
    public static NewYearSkinControll Instance;
    public static int buttonId = 100;

    public Sprite currentSkin;
    [SerializeField] private Sprite[] skinSprite = new Sprite[6];
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    /// Method on button
    public void SetSkin(int skinIndex)
    {
        switch (skinIndex)
        {
            //deer
            case 0:
                currentSkin = skinSprite[0];
                buttonId = 0;
                break;

            //green hat
            case 1:
                currentSkin = skinSprite[1];
                buttonId = 1;
                break;

            //santa klaus
            case 2:
                currentSkin = skinSprite[2];
                buttonId = 2;
                break;

            //red hat
            case 3:
                currentSkin = skinSprite[3];
                buttonId = 3;
                break;

            //geerland
            case 4:
                currentSkin = skinSprite[4];
                buttonId = 4;
                break;

            //new year toy
            case 5:
                currentSkin = skinSprite[5];
                buttonId = 5;
                break;


            default:
                break;
        }
    }
    public Sprite SkinItem()
    {
        if (currentSkin == null)
        {
            return null;
        }
        else
        {
            return currentSkin;
        }
    }

}
