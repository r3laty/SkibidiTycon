using UnityEngine;

public class SkibidiToiletController : MonoBehaviour
{
    [HideInInspector] public bool wasArrive;

    [SerializeField] private int toiletPrice;

    [SerializeField] private int speed = 5;

    private Rigidbody2D _rb;
    private Animator _animator;

    private FacroryController _factory;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
 
    private void FixedUpdate()
    {
        _rb.velocity = Vector3.one * (-speed) * Time.fixedDeltaTime;

        _animator.SetBool("Spawned", true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            wasArrive = true;

            Debug.Log("End");
        }
    }
}