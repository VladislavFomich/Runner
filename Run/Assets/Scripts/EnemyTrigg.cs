using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;

public class EnemyTrigg : MonoBehaviour
{
    private bool _onAttack;
    public bool OnAttack { get => _onAttack; }
    private void OnTriggerEnter(Collider other)
    {
        _onAttack = true;
    }
    private void OnTriggerExit(Collider other)
    {
        _onAttack = false;
    }

}
