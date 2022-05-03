using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;

public class Arrow : Shell
{
    
    private LaneRunner _runner;

    private void Awake()
    {
       _runner = GetComponent<LaneRunner>();
        Archer archer = GetComponentInParent<Archer>();
        _runner.lane = archer.Line;
        transform.SetParent(null);
    }


    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other); 
        Destroy(gameObject);
    }

}
