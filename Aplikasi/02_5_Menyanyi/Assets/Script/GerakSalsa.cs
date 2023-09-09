using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakSalsa : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void playAnimator()
    {
        animator.SetBool("Gerak", true);
        animator.SetBool("Balik", false);
    }

    public void stopAnimator()
    {
        animator.SetBool("Gerak", false);
        animator.SetBool("Balik", true);
    }
}
