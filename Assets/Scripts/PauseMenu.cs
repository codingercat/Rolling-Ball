using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    
    public GameObject pauseMenuUI;
    void Update()
    {
    
    }
    
    
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
      


    public void Pause()
    {
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;      
    }
    
    
    
    public void QuitGame()
    {
    Debug.Log ("QUIT!");
    Application.Quit();
    }

}
