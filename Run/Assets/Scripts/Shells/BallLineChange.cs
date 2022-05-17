using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;

public class BallLineChange : MonoBehaviour
{
    private LaneRunner _laneRunner;

    private void Awake()
    {
        _laneRunner = GetComponent<LaneRunner>();
    }
    private void Start()
    {
        transform.SetParent(null);
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (_laneRunner.lane)
        {
            case 1:
            case 3:
                _laneRunner.lane = 2;
                break;
            case 2:
                int rndLane = Random.Range(0, 2);
                if (rndLane == 0)
                    _laneRunner.lane++;
                else
                    _laneRunner.lane--;
                break;

        }
    }
}
