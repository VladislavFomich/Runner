using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Run", true);
    }

    public void Attack()
    {
        animator.SetBool("Run", false);
        animator.SetTrigger("Attack");
        animator.SetBool("Run", true);
    }
}
