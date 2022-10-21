using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject main_menu;
    [SerializeField] private GameObject level_menu;
    [SerializeField] private GameObject config_menu;
    public void Play()
    {
        SceneManager.LoadSceneAsync(1);
        //level_menu.SetActive(true);
        //main_menu.SetActive(false);
    }
    public void Config()
    {
        config_menu.SetActive(true);
        main_menu.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}