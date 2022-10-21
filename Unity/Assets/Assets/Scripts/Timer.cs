using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI text;
    [SerializeField]private TextMeshProUGUI end_text;
    private bool end;
    private float start_time, time;
    private string minutes, seconds;
    private void Start()
    {
        start_time = Time.time;
    }
    private void FixedUpdate()
    {
        if(!end)
        {
            time = Time.time - start_time;
            minutes = ((int) time / 60).ToString();
            seconds = (time % 60).ToString("f2");
            text.text = minutes + ":" + seconds;
            end_text.text = minutes + ":" + seconds;
        }
    }
    public void End()
    {
        end = true;
    }
}