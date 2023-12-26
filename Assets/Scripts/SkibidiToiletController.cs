using UnityEngine;

public class SkibidiToiletController : MonoBehaviour
{
    public int toiletPrice;

    [SerializeField] private Transform managerPosition;

    [SerializeField] private float speed = 5;

    [SerializeField] private AudioSource sound;

    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        sound = GameObject.FindGameObjectWithTag("AddMoney").GetComponent<AudioSource>();
    }
    private void Start()
    {
        if (GunControll.pistolAssigned) toiletPrice *= 2;
        if (GunControll.mediumGunAssigned) toiletPrice *= 3;
        if (GunControll.bigGunAssigned) toiletPrice *= 4;
    }
    private void FixedUpdate()
    {
        _rb.velocity = Vector3.one * (-speed) * Time.fixedDeltaTime;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            MoneyHandler.MoneyCount += toiletPrice;
            sound.Play();
            Destroy(gameObject);
        }
    }
}