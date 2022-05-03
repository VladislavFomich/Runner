using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    [SerializeField] private SwipeModel _swipeModel;

    private int _numModel;
    private int _isTutoriald = 1;


    private void Start()
    {
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
        _isTutoriald = 2;
        PlayerPrefs.SetInt("Tutorial", _isTutoriald);
    }
    public int LoadTutorial()
    {
        return PlayerPrefs.GetInt("Tutorial");
    }
    
}
