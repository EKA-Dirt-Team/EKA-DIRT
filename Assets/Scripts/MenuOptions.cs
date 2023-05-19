using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{
    
    public GameObject menu;
    public GameObject gameUI;
    public GameObject audioButton;
    public Color audioDisabledColor;
    public Color audioEnabledColor;

    private bool menu_visible = false;
    private bool audio_state = true;
    
    private void Start()
    {
        menu.SetActive(menu_visible);
        gameUI.SetActive(!menu_visible);
        menu_visible = menu.activeSelf;
        audio_state = AudioListener.pause;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowMenu();
        }
    }
    
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
        audio_state = !audio_state;
        AudioListener.pause = audio_state;
        
        if (audio_state)
        {
            Debug.Log("Audio On");
            audioButton.GetComponent<Image>().color = audioEnabledColor;
        }
        else
        {
            Debug.Log("Audio Off");
            audioButton.GetComponent<Image>().color = audioDisabledColor;
        }
        
    }
}
