using UnityEngine;
public class SkinControll : MonoBehaviour
{
    public static SkinControll Instance;
    public Sprite currentSkin;
    [SerializeField] private Sprite[] skinSprite = new Sprite[18];
    private int skinIndex;
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
            case 0:
                currentSkin = skinSprite[0];
                Debug.Log(skinSprite[0].name + " sprite name");
                break;
            case 1: currentSkin = skinSprite[1]; break;
            case 2: currentSkin = skinSprite[2]; break;
            case 3: currentSkin = skinSprite[3]; break;
            case 4: currentSkin = skinSprite[4]; break;
            case 5: currentSkin = skinSprite[5]; break;
            case 6: currentSkin = skinSprite[6]; break;
            case 7: currentSkin = skinSprite[7]; break;
            case 8: currentSkin = skinSprite[8]; break;
            case 9: currentSkin = skinSprite[9]; break;
            case 10: currentSkin = skinSprite[10]; break;
            case 11: currentSkin = skinSprite[11]; break;
            case 12: currentSkin = skinSprite[12]; break;
            case 13: currentSkin = skinSprite[13]; break;
            case 14: currentSkin = skinSprite[14]; break;
            case 15: currentSkin = skinSprite[15]; break;
            case 16: currentSkin = skinSprite[16]; break;
            case 17: currentSkin = skinSprite[17]; break;

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
