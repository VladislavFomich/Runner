using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.VFX;

public class PlayerController : BaseController
{

    

    [SerializeField] private PlayerInterfaceCanvas _playerInterfaceCanvas;
    [SerializeField] private VisualEffect _slashEffect;
    private PlayerDeath _playerDeath;
    private PlayerAnimController _animController;
    private bool _isAttack;
    public bool IsAttack { get => _isAttack; }
    

    public int Damage { get => _damage; }
    public int Health { get => _health; }
    public int Level { get => _level; }
    public float MaxExperience { get => _maxExperience; }
    public float CurrentExpierence { get => _currentExperience; }

    private int _level = 1;
    private float _maxExperience = 100;
    private float _currentExperience;

    public override void Awake()
    {
        base.Awake();
        _animController = GetComponent<PlayerAnimController>();
        _playerDeath = GetComponent<PlayerDeath>();
    }

    public void FinishAttack()
    {
        _isAttack = false;
    }
    private void Update()
    {
        if (_health < 1)
        {
            _playerDeath.Death();
        }
    }
    public override void Attack()
    {
        _animController.Attack();
        _isAttack = true;
        _slashEffect.Play();
    }

    public override void TakeDamage(int damage)
    {      
        base.TakeDamage(damage);
        _playerInterfaceCanvas.UpdateHealth();
    }
    private void LevelUp()
    {
        _currentExperience = 0f; 
        _level += 1;
        _playerInterfaceCanvas.UpdateLevelUp();
       
    }
    public void GrowLevel(float exp)
    {
        _currentExperience += exp;
        _playerInterfaceCanvas.UpdateGrowLevel();
        if (_currentExperience >= _maxExperience)
        {
            LevelUp();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            _playerInterfaceCanvas.UpdateCoinScore();
            Destroy(other.gameObject);
        }
    }

}
