using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private GameObject _endGameCvs;
    
    public void Death()
    {
        _endGameCvs.SetActive(true);
    }
}
