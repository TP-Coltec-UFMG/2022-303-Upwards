using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI score_text;
    [SerializeField]private TextMeshProUGUI end_score_text;
    private int score;
    private void awake()
    {
        score = 0;
    }
    public void Scoring()
    {
        score++;
        score_text.text = score.ToString();
        end_score_text.text = score.ToString();
    }
}