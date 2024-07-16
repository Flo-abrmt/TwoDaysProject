using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject optionsMenu; // Assign in inspector
    public GameObject configWindow; // Assign in inspector

    public void StartGame()
    {
        configWindow.SetActive(true);
    }

    public void OpenOptions()
    {
        optionsMenu.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsMenu.SetActive(false);
    }

    public void CloseConfig()
    {
        configWindow.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

