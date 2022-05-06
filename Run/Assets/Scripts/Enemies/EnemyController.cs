using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyController : BaseController
{

    [SerializeField] protected Animator animator;
    [SerializeField] private BoxCollider _collider;


    [SerializeField] private float _exp;


    public float Exp { get => _exp; }


   
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        if(_health < 1)
        {
            Death();
            PlayerController _playerController = FindObjectOfType<PlayerController>();
            _playerController.GrowLevel(Exp);
        }
    }
    public override void Attack()
    {
        base.Attack();
        animator.SetBool("Shoot", true);
    }

   public virtual void Death()
    {
        _collider.enabled = false;
        animator.SetBool("IsDie", true);
    }
  
}
