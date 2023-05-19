using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    
    public GameObject menu;
    public GameObject gameUI;

    private bool menu_visible = false;
    
    public void ShowMenu()
    {
        Debug.Log("Menu Shown");
        menu_visible = !menu_visible;
        
        menu.SetActive(menu_visible);
        gameUI.SetActive(!menu_visible);
    }
    
    public void MainMenu()
    {
        Debug.Log("Going to Main Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartLevel()
    {
        Debug.Log("Restarting Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void audioToggle()
    {
        Debug.Log("Audio Toggled");
        AudioListener.pause = !AudioListener.pause;
    }
}
