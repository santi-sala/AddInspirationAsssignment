using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMainGameLoop : MonoBehaviour
{
    public void LoadMainGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
