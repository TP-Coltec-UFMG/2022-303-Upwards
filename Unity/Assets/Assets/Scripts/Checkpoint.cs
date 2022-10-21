using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Checkpoint : MonoBehaviour
{
    [SerializeField]private GameObject flag1, flag2;
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if(Collision.gameObject.name == "Player")
        {
            flag1.SetActive(true);
            flag2.SetActive(false);
        }
    }
}