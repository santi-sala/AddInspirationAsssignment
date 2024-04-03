using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class UIManager : Singleton<UIManager>
{
    [SerializeField]
    private TextMeshProUGUI _ammoText;
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    [SerializeField]
    private TextMeshProUGUI _timeText;
    [SerializeField]
    private GameObject _gameOverPanel;
    [SerializeField]
    private TextMeshProUGUI _timeGameOverText;
    [SerializeField]
    private TextMeshProUGUI _scoreGameOverText;
    


    private int _score = 0;

    private void Awake()
    {
        _gameOverPanel.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
        PlayerManager.Instance.OnChangeAmmo += UpdateAmmo;
    }

    private void UpdateAmmo(int obj)
    {
        _ammoText.text = obj.ToString();
    }

    public void UpdateScore()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        _gameOverPanel.SetActive(true);
        _scoreGameOverText.text = "Final score: " +_score.ToString();
        _timeGameOverText.text = "Time: " + _timeText;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

}
