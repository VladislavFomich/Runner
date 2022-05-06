using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private float rayDist = 1f;
    [SerializeField] private Transform grCheckTransf;
    private bool _onGround;
    public bool OnGround { get => _onGround; }

    int numLayer = 1 << 6;

    private void FixedUpdate()
    {
         _onGround = Physics.Raycast(grCheckTransf.position, Vector3.down, rayDist, numLayer);     
    }

}