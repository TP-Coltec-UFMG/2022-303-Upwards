using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelMenu : MonoBehaviour
{
    [SerializeField] private GameObject main_menu;
    [SerializeField] private GameObject level_menu;
    public void Back()
    {
        main_menu.SetActive(true);
        level_menu.SetActive(false);
    }
    public void Level1()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Level2()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Level3()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void Level4()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void Level5()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void Level6()
    {
        SceneManager.LoadSceneAsync(6);
    }
    public void Level7()
    {
        SceneManager.LoadSceneAsync(7);
    }
    public void Level8()
    {
        SceneManager.LoadSceneAsync(8);
    }
    public void Level9()
    {
        SceneManager.LoadSceneAsync(9);
    }
    public void Level10()
    {
        SceneManager.LoadSceneAsync(10);
    }
    public void Level11()
    {
        SceneManager.LoadSceneAsync(11);
    }
    public void Level12()
    {
        SceneManager.LoadSceneAsync(12);
    }
    public void Level13()
    {
        SceneManager.LoadSceneAsync(13);
    }
    public void Level14()
    {
        SceneManager.LoadSceneAsync(14);
    }
    public void Level15()
    {
        SceneManager.LoadSceneAsync(15);
    }
}