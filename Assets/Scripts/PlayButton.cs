using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menuCanvas;

    public void Start()
    {
        Time.timeScale = 0.000001f;
    }

    public void PlayGame()
    {
        menuCanvas.SetActive(false);
        Time.timeScale = 1;
        
    }
}
