using UnityEngine;
public class SkinControll : MonoBehaviour
{
    public static SkinControll Instance;
    public static int buttonId = 100;

    public Sprite currentSkin;
    [SerializeField] private Sprite[] skinSprite = new Sprite[18];
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void SetSkin(int skinIndex)
    {
        switch (skinIndex)
        {
            //red skin
            case 0: currentSkin = skinSprite[0];
                buttonId = 0;
                break;
            case 1: currentSkin = skinSprite[1]; 
                buttonId = 0;
                break;
            case 2: currentSkin = skinSprite[2]; 
                buttonId = 0;
                break;
            
            //blue skin
            case 3: currentSkin = skinSprite[3];
                buttonId = 1;
                break;
            case 4: currentSkin = skinSprite[4];
                buttonId = 1;
                break;
            case 5: currentSkin = skinSprite[5];
                buttonId = 1;
                break;
            
            //purple skin
            case 6: currentSkin = skinSprite[6];
                buttonId = 2;
                break;
            case 7: currentSkin = skinSprite[7];
                buttonId = 2;
                break;
            case 8: currentSkin = skinSprite[8];
                buttonId = 2;
                break;
            
            //green skin
            case 9: currentSkin = skinSprite[9];
                buttonId = 3;
                break;
            case 10: currentSkin = skinSprite[10];
                buttonId = 3;
                break;
            case 11: currentSkin = skinSprite[11];
                buttonId = 3;
                break;

            //yellow skin
            case 12: currentSkin = skinSprite[12];
                buttonId = 4;
                break;
            case 13: currentSkin = skinSprite[13];
                buttonId = 4;
                break;
            case 14: currentSkin = skinSprite[14];
                buttonId = 4;
                break;

            //white skin
            case 15: currentSkin = skinSprite[15];
                buttonId = 5;
                break;
            case 16: currentSkin = skinSprite[16];
                buttonId = 5;
                break;
            case 17: currentSkin = skinSprite[17];
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
