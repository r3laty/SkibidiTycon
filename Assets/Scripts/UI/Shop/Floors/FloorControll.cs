using UnityEngine;

public class FloorControll : MonoBehaviour
{
    public static FloorControll Instance;
    public static int buttonId = 100;

    public Sprite currentFloar;
    [SerializeField] private Sprite[] floorsSprites = new Sprite[4];
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    /// Method on button
    public void SetFloar(int floarIndex)
    {
        switch (floarIndex)
        {
            //chess
            case 1:
                currentFloar = floorsSprites[0];
                buttonId = 1;
                break;


            //iron
            case 2:
                currentFloar = floorsSprites[1];
                buttonId = 2;
                break;

            //golden
            case 3:
                currentFloar = floorsSprites[2];
                buttonId = 3;
                break;

            default:
                break;
        }
    }
    public Sprite FloorItem()
    {
        if (currentFloar == null)
        {
            return null;
        }
        else
        {
            return currentFloar;
        }
    }

}
