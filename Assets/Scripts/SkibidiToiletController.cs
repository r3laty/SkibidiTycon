using UnityEngine;

public class SkibidiToiletController : MonoBehaviour
{
    [SerializeField] private int toiletPrice;

    [SerializeField] private int speed = 5;

    private Rigidbody2D _rb;
    private Animator _animator;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
 
    private void FixedUpdate()
    {
        _rb.velocity = Vector3.one * (-speed) * Time.fixedDeltaTime;

        //_animator.SetBool("Spawned", true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}