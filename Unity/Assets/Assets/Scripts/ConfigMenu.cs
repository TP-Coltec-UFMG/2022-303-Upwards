using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ConfigMenu : MonoBehaviour
{
    [SerializeField] private GameObject main_menu;
    [SerializeField] private GameObject config_menu;
    [SerializeField] private GameObject video_menu;
    [SerializeField] private GameObject audio_menu;
    [SerializeField] private GameObject gameplay_menu;
    [SerializeField] private GameObject accessibility_menu;
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