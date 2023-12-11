using UnityEngine;

public class FactoryMachine : MonoBehaviour
{
    [HideInInspector] public bool wasArrived;

    [SerializeField] private ToiletManager toiletManager;

    private int _passed = 1;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("SkibidiToilet"))
        {
            toiletManager.ToiletRemoved();

            Destroy(collision.gameObject);
        }
    }
}
