using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;

public class LoadingScreen : MonoBehaviour
{
   [SerializeField] private GameObject _player;
   [SerializeField] private GameObject _interfaceCanvas;


    private void Start()
    {
        Time.timeScale = 1f;
    }
    private void Update()
    {
        if (LevelGenerator.instance.ready)
        {
            _player.SetActive(true);
            _interfaceCanvas.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
