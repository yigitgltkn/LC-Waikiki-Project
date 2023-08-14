using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraAnimasyonu : MonoBehaviour
{
    private Animator animator;
    private bool animationFinished = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = true;
        animator.Play("KameraAnimasyon");
    }

    private void Update()
    {
        // Animasyonun sonunda kameranın hareketini durdur
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f && !animationFinished)
        {
            animationFinished = true;
            animator.Play("Idle");
            animator.enabled = false;
        }
    }
}








