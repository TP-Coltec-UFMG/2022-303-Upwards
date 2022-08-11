using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject config_menu;
    public GameObject video_menu;
    public GameObject audio_menu;
    public GameObject gameplay_menu;
    public GameObject accessibility_menu;
    //Main Menu
    public void Play()
    {
        SceneManager.LoadSceneAsync(1);
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
    //Config Menu
    public void Video()
    {
        video_menu.SetActive(true);
        audio_menu.SetActive(false);
        gameplay_menu.SetActive(false);
        accessibility_menu.SetActive(false);
    }
    public void Audio()
    {
        audio_menu.SetActive(true);
        video_menu.SetActive(false);
        gameplay_menu.SetActive(false);
        accessibility_menu.SetActive(false);
    }
    public void Gameplay()
    {
        gameplay_menu.SetActive(true);
        video_menu.SetActive(false);
        audio_menu.SetActive(false);
        accessibility_menu.SetActive(false);
    }
    public void Accessibility()
    {
        accessibility_menu.SetActive(true);
        video_menu.SetActive(false);
        audio_menu.SetActive(false);
        gameplay_menu.SetActive(false);
    }
    public void Back()
    {
        main_menu.SetActive(true);
        config_menu.SetActive(false);
    }
}