using System.Diagnostics.Contracts;
using UnityEngine;

public class GunControll : MonoBehaviour
{
    public static GunControll Instance;
    public static int buttonId = 100;

    public Sprite currentGun;
    [SerializeField] private Sprite[] allTypeOfGuns = new Sprite[3];

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    /// Method on button
    public void SetWeapon(int weaponIndex)
    {
        switch (weaponIndex)
        {
            //pistol
            case 0: currentGun = allTypeOfGuns[0];
                buttonId = 0;
                break;

            //medium gun
            case 1: currentGun = allTypeOfGuns[1];
                buttonId = 1;
                break;
                
            //big gun
            case 2: currentGun = allTypeOfGuns[2];
                buttonId = 2;
                break;
            default:
                break;
        }
    }

    public Sprite GunItem()
    {
        if (currentGun == null)
        {
            return null;
        }
        else
        {
            return currentGun;
        }
    }
}
