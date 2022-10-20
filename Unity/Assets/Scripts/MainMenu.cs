using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject main_menu;
    [SerializeField] private GameObject level_menu;
    [SerializeField] private GameObject config_menu;
    public void Play()
    {
        level_menu.SetActive(true);
        main_menu.SetActive(false);
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