using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTrigg : MonoBehaviour
{
    private PlayerController _playerController;


    private void Start()
    {
        _playerController = transform.root.GetComponent<PlayerController>(); 
    }
    private void OnTriggerEnter(Collider other)
    {
        Archer archer = other.GetComponent<Archer>();
        if (archer != null && _playerController.IsAttack)
        {
            archer.TakeDamage(_playerController.Damage);
        }
        AttackBall attackBall = other.GetComponent<AttackBall>();
        if (attackBall != null && _playerController.IsAttack)
        {
            attackBall.AttackWizzard();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Archer archer = other.GetComponent<Archer>();
        if (archer != null && _playerController.IsAttack)
        {
            archer.TakeDamage(_playerController.Damage);
        }
        AttackBall attackBall = other.GetComponent<AttackBall>();
        if (attackBall != null && _playerController.IsAttack)
        {
            attackBall.AttackWizzard();
        }
    }
}
