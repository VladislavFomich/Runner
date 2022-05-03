using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;

public class LineChanger : MonoBehaviour
{
    private LaneRunner _runner;
    void Start()
    {
        _runner = GetComponent<LaneRunner>();
    }

    public void MoveRight()
    {
        _runner.lane++;
    }
    public void MoveLeft()
    {
        _runner.lane--;
    }
}
