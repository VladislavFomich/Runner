using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseController : MonoBehaviour
{
   [SerializeField] protected int _health;
   [SerializeField] protected int _damage;
   [SerializeField] private GameObject _smash;

    protected ParticleSystem smashVfx;
    public virtual void Awake()
    {
       smashVfx = _smash.GetComponent<ParticleSystem>();
    }
    public virtual void Attack()
    {

    }
    public virtual void TakeDamage(int damage)
    {
        smashVfx.Play();
        _health -= damage;

    }
}
