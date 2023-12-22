using System.Collections;
using UnityEngine;

public class SkibidiToiletController : MonoBehaviour
{
    [SerializeField] private Transform managerPosition;

    [SerializeField] private int toiletPrice;

    [SerializeField] private int speed = 5;

    private int _currentPoint = 0;
    private Rigidbody2D _rb;
    private Animator _animator;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    //private void Start()
    //{
    //    StartCoroutine(MoveTowardsAssemblyLine());
    //}
    //private IEnumerator MoveTowardsAssemblyLine()
    //{
    //    while (true)
    //    {
    //        float screenUnit = Screen.width / 1920f;

    //        transform.position = new Vector3(transform.position.x - speed * screenUnit, transform.position.y, transform.position.z);
    //        yield return new WaitForSeconds(1);
    //    }
    //}
    private void FixedUpdate()
    {
        _rb.velocity = Vector3.one * (-speed) * Time.fixedDeltaTime;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}