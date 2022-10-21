using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Coins : MonoBehaviour
{
    [SerializeField]private Score score;
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if(Collision.gameObject.name == "Player")
        {
            score.Scoring();
            Destroy(gameObject);
        }
    }
}