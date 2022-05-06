using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;

public class SaveLoad : MonoBehaviour
{
    [SerializeField] private SwipeModel _swipeModel;

    private int _numModel;


    private void Start()
    {  // To Do another script with Tutorial Spwan
       // LevelGenerator.instance.startLevel = LoadTutorial();
        //LevelGenerator.instance.StartGeneration();
        Time.timeScale = 1f;
    }
    public void SaveNumModel()
    {
        _numModel = _swipeModel.Position;
        PlayerPrefs.SetInt("ModelNum", _numModel);
    }
    public int LoadNumModel()
    {
        return PlayerPrefs.GetInt("ModelNum");
    }
    public void SaveTutorial()
    {
        PlayerPrefs.SetInt("Tutorial", 1);
    }
    public int LoadTutorial()
    {
        return PlayerPrefs.GetInt("Tutorial");
    }
    
}
