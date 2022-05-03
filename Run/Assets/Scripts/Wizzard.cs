using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizzard : EnemyController
{
    [SerializeField] private GameObject[] _spell;
    [SerializeField] private Transform _spellSpawnPoint;
    [SerializeField] public Transform _startPos;


    private void Start()
    {
        StartCoroutine(CastRandomSpell());
        transform.position = _startPos.position;
    }

    public void CastEvent()
    {
        SpawnSpell();
    }

    private void SpawnSpell()
    {
        Instantiate(_spell[Random.Range(0,_spell.Length)], _spellSpawnPoint);
    }
    public void StopSpellEvent()
    {
        animator.SetBool("Shoot", false);
    }
    private IEnumerator CastRandomSpell()
    {
        while (true)
        {
            Attack();
            yield return new WaitForSeconds(5f);
        }
    }

}
