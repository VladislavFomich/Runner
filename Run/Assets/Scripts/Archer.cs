using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : EnemyController
{
    [SerializeField] private EnemyTrigg _enemyTrigg;

    public GameObject arrow;
    public Transform arrowSpawn;
    public int Line { get => _line; }

    [SerializeField] private int _line;

    private void Update()
    {
        if (_enemyTrigg.OnAttack)
        {
            Attack();
        }
    }
    public void ShootEvent()
    {
        Instantiate(arrow, arrowSpawn);
    }
}
