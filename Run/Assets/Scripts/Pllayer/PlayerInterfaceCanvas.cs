using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;
using TMPro;
using UnityEngine.UI;
public class PlayerInterfaceCanvas : MonoBehaviour
{
    [SerializeField] private LaneRunner _runner;
    [SerializeField] private TMP_Text _scoreTextMeshPro;
    [SerializeField] private TMP_Text _coinTextMeshPro;
    [SerializeField] private TMP_Text _levelText;
    [SerializeField] private GameObject[] _healthImage;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private Slider _levelSlider;
    private float _scoreCode;
    private int _scoreToView;
    private int _coinScore;

    private void Start()
    {
        for (int i = 0; i < _playerController.Health; i++)
        {
            _healthImage[i].SetActive(true);
        }
        _levelText.text = $"Level {_playerController.Level}";
    }
    private void Update()
    {
        _scoreCode += 5 * _runner.followSpeed * Time.deltaTime;
        _scoreToView = (int)_scoreCode; 
        _scoreTextMeshPro.text = _scoreToView.ToString();
    }
    public void UpdateCoinScore()
    {
        _coinScore++;
        _coinTextMeshPro.text = _coinScore.ToString();
    }
    public void UpdateHealth()
    {
        for (int i = 0; i < _healthImage.Length; i++)
        {
            if (i > _playerController.Health - 1)
            {
                _healthImage[i].SetActive(false);
            }
        }
    }
    public void UpdateLevelUp()
    {
        UpdateGrowLevel();
        _levelText.text = $"Level {_playerController.Level}";
    }
    public void UpdateGrowLevel()
    {
        _levelSlider.value = _playerController.CurrentExpierence / _playerController.MaxExperience;
    }
}
