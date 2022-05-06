using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Shell
{
    BoxCollider boxCollider;
    public override void Start()
    {
        base.Start();
        boxCollider = GetComponent<BoxCollider>();
    }
    public override void OnCollisionEnter(Collision other)
    {
        if (other.transform.GetComponent<PlayerController>() != null)
        {
           boxCollider.enabled = false;
        }
        base.OnCollisionEnter(other);
    }
}
