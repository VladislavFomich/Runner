using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;

public class AttackBall : MonoBehaviour
{
    [SerializeField] private int _speed = 100;

    private Transform _wizzardTransfotm;
    private LaneRunner _laneRunner;
    private SphereCollider _sphereCollider;

    private bool _isAttacked;
    public int damage;

    private void Awake()
    {
        _wizzardTransfotm = GetComponentInParent<Wizzard>().transform;
        _laneRunner = GetComponent<LaneRunner>();
        _sphereCollider = GetComponent<SphereCollider>();
    }
    private void Start()
    {
        transform.SetParent(null);
    }
    private void Update()
    {
        if (_isAttacked)
        {
           transform.position =Vector3.MoveTowards(transform.position, _wizzardTransfotm.position, _speed * Time.deltaTime);
        }
    }

    public void AttackWizzard()
    {
        _sphereCollider.isTrigger = true;
        _laneRunner.enabled = false;
        _isAttacked= true;
    }

    public void OnTriggerEnter(Collider other)
    {
        Wizzard wizzard = other.gameObject.GetComponent<Wizzard>();
        if (wizzard != null)
        {
            wizzard.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
