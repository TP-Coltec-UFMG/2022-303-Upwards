using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pause_menu;
    public GameObject config_menu;
    public GameObject video_menu;
    public GameObject audio_menu;
    public GameObject gameplay_menu;
    public GameObject accessibility_menu;
    private float pause;
    private void Start()
    {
        pause = 0;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pause == 0)
            {
                Pause();
            }
            else if(pause == 1)
            {
                Resume();
            }
            else if(pause == 2)
            {
                Back();
            }
        }
    }
    //Pause Menu
    public void Pause()
    {
        pause = 1;
        Time.timeScale = 0f;
        pause_menu.SetActive(true);
    }
    public void Resume()
    {
        pause = 0;
        pause_menu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Config()
    {
        pause = 2;
        config_menu.SetActive(true);
        pause_menu.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
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
        pause = 1;
        pause_menu.SetActive(true);
        config_menu.SetActive(false);
    }
}