using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class control1 : MonoBehaviour
{
    public void ResetTheGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    print("The button is working.");
}
    public void ResetTheGameLevel2()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    print("The button is working.");  
    }
}
