using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Effector2D sEffect;

    public void StartGame()
    {
        Debug.Log("Loading game...");
        SceneManager.LoadScene("game");

    }

    public void StartMenu()
    {
        Debug.Log("Returning to start menu...");
        SceneManager.LoadScene("start-menu");
    }
    public void ExitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();
    }

    public void SettingsMenu()
    {
        Debug.Log("Loading settings menu...");
        SceneManager.LoadScene("settings-menu");
    }

    public void SelectEffect()
    {
        
    }

}
