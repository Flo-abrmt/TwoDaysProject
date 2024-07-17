using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject OptionsMenu; // Assign in inspector
    public GameObject PreStartGameConfig; // Assign in inspector

    public void StartGame()
    {
        PreStartGameConfig.SetActive(true);
    }

    public void OpenOptions()
    {
        OptionsMenu.SetActive(true);
    }

    public void CloseOptions()
    {
        OptionsMenu.SetActive(false);
    }

    public void CloseConfig()
    {
        PreStartGameConfig.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

