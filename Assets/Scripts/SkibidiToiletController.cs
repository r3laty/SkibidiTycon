using System.Collections;
using UnityEngine;

public class SkibidiToiletController : MonoBehaviour
{
    [SerializeField] private Transform managerPosition;

    [SerializeField] private int toiletPrice;

    [SerializeField] private float speed = 5;


    private int _pauseTime = 1;
    private bool _isMoving;
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
    //private void Update()
    //{
    //    // Move the object
    //    if (_isMoving)
    //    {
    //        transform.Translate(Vector2.left * speed * Time.deltaTime);
    //    }
    //    // Check if the object has reached the end of the movement
    //    if (_isMoving && transform.position.x > -8.56f) // Adjust the end point as needed
    //    {
    //        _isMoving = false;
    //        StartCoroutine(Pause());
    //    }
    //    else if (!_isMoving && transform.position.x < -8.50f) // Adjust the end point as needed
    //    {
    //        _isMoving = true;
    //        StartCoroutine(Pause());
    //    }
    //}

    //// Coroutine for introducing a pause
    //IEnumerator Pause()
    //{
    //    yield return new WaitForSeconds(_pauseTime);
    //}

    private void FixedUpdate()
    {
        _rb.velocity = Vector3.one * (-speed) * Time.fixedDeltaTime;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            MoneyHandler.MoneyCount += toiletPrice;
            Destroy(gameObject);
        }
    }
}