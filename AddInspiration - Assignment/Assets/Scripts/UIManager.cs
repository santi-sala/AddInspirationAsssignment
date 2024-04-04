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

    private float _timer;
    private float _seconds;
    private float _minutes;




    private int _score = 0;

    private void OnEnable()
    {
        _gameOverPanel.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
        PlayerManager.Instance.OnChangeAmmo += UpdateAmmo;
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        _seconds = ((int)_timer % 60);
        _minutes = ((int)_timer / 60);
        _timeText.text = string.Format("{0:00}:{1:00}", _minutes, _seconds);
        
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
        _gameOverPanel.SetActive(true);
        _scoreGameOverText.text = "Final score: " +_score.ToString();
        _timeGameOverText.text = "Time: " + _timeText.text;
        Time.timeScale = 0;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Settings()
    {
        Debug.Log("Settings");
    }

}
