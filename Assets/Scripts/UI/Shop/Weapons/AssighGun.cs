using UnityEngine;

public class AssighGun : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Update()
    {
        SetGun();
    }
    private void SetGun()
    {
        if (GunControll.buttonId == 0) spriteRenderer.sprite = GunControll.Instance.GunItem();
        if (GunControll.buttonId == 1) spriteRenderer.sprite = GunControll.Instance.GunItem();
        if (GunControll.buttonId == 2) spriteRenderer.sprite = GunControll.Instance.GunItem();
    }
}
