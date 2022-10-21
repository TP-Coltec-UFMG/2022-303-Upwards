using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelEnd : MonoBehaviour
{
    [SerializeField] private GameObject level_end;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            level_end.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Next()
    {
        Time.timeScale = 1f;
        level_end.SetActive(false);
        SceneManager.LoadSceneAsync(0);
    }
    public void Replay()
    {
        Time.timeScale = 1f;
        level_end.SetActive(false);
        SceneManager.LoadSceneAsync(1);
    }

}