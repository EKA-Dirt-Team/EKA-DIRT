using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Test Commit
public class Buttons : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("comic");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
