using System.Diagnostics.Contracts;
using Unity.VisualScripting;
using UnityEngine;

public class GunControll : MonoBehaviour
{
    public static GunControll Instance;
    public static int buttonId = 100;
    public static bool pistolAssigned;
    public static bool mediumGunAssigned;
    public static bool bigGunAssigned;

    public Sprite currentGun;
    [SerializeField] private Sprite[] allTypeOfGuns = new Sprite[3];
    private SkibidiToiletController _toiletController;

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
        _toiletController = null;
        switch (weaponIndex)
        {
            //pistol
            case 0:
                currentGun = allTypeOfGuns[0];
                buttonId = 0;
                _toiletController = GameObject.FindGameObjectWithTag("SkibidiToilet").GetComponent<SkibidiToiletController>();
                _toiletController.toiletPrice *= 2;

                pistolAssigned = true;
                break;

            //medium gun
            case 1:
                currentGun = allTypeOfGuns[1];
                buttonId = 1;
                _toiletController = GameObject.FindGameObjectWithTag("SkibidiToilet").GetComponent<SkibidiToiletController>();
                _toiletController.toiletPrice *= 3;

                pistolAssigned = false;
                mediumGunAssigned = true;
                break;

            //big gun
            case 2:
                currentGun = allTypeOfGuns[2];
                buttonId = 2;
                _toiletController = GameObject.FindGameObjectWithTag("SkibidiToilet").GetComponent<SkibidiToiletController>();
                _toiletController.toiletPrice *= 4;

                pistolAssigned = false;
                mediumGunAssigned = false;
                bigGunAssigned = true;
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
