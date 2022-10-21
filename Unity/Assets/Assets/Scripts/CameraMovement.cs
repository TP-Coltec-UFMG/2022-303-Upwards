using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float max_distance;
    private GameObject player;
    private void Awake()
    {
        player = GameObject.Find("Player");
    }
    private void Update()
    {
        if(player.transform.position.y > -max_distance)
        {
            if(transform.position.y > player.transform.position.y + max_distance)
            {
                transform.position = new Vector3(transform.position.x, player.transform.position.y + max_distance, transform.position.z);
            }
            else if(transform.position.y < player.transform.position.y - max_distance)
            {
                transform.position = new Vector3(transform.position.x, player.transform.position.y - max_distance, transform.position.z);
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
        }
    }
}