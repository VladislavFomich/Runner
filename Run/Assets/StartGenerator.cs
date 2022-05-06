using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;

public class StartGenerator : MonoBehaviour
{
    [SerializeField] private SaveLoad _saveLoad;
    void Start()
    {
            LevelGenerator.instance.startLevel = _saveLoad.LoadTutorial();
            LevelGenerator.instance.StartGeneration();
    }

}
