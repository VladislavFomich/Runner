using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 10f;

    private GroundCheck _grCheck;

    private Rigidbody _rig;

    private void Start()
    {
        _rig = GetComponent<Rigidbody>();
        _grCheck = GetComponent<GroundCheck>();

    }

    public void Jump()
    {
        if (_grCheck.OnGround)
        {
           _rig.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }
}
