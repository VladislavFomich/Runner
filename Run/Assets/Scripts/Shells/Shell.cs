using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Shell : MonoBehaviour
{
  [SerializeField] protected int damage;

    public virtual void Start()
    {
        transform.SetParent(null);
    }
    public virtual void OnTriggerEnter(Collider other)
    {
        PlayerController playerController = other.GetComponent<PlayerController>();
        if (playerController != null)
        {
           playerController.TakeDamage(damage);
        }
    }

    public virtual void OnCollisionEnter(Collision other)
    {
        PlayerController playerController = other.transform.GetComponent<PlayerController>();
        if (playerController != null)
        {
            playerController.TakeDamage(damage);
        }
    }

}
