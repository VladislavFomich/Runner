using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerModel : MonoBehaviour
{
    [SerializeField] private GameObject[] _playerModels;
    [SerializeField] private SaveLoad _saveLoad;
    [SerializeField] private GameObject _player;
    private int _numModel;

    private void Awake()
    {
      GameObject model = Instantiate(_playerModels[_saveLoad.LoadNumModel()]);
        // model.transform.SetParent(transform);
        model.transform.SetParent(_player.transform);
      model.transform.localPosition = new Vector3(0, 0, 0);
    }
} 
