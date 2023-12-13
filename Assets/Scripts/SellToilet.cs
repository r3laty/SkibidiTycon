using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellToilet : MonoBehaviour
{
    [HideInInspector] public bool wasArrived;

    [SerializeField] private ToiletManager toiletManager;

    [SerializeField] private Animator moneyAnimator;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("SkibidiToilet"))
        {
            toiletManager.ToiletRemoved();

            Destroy(collision.gameObject);

            moneyAnimator.SetBool("Play", true);
            StartCoroutine(TurnOffAnimation());
        }
    }
    private IEnumerator TurnOffAnimation()
    {
        yield return new WaitForSeconds(1);
        moneyAnimator.SetBool("Play", false);
    }
}
