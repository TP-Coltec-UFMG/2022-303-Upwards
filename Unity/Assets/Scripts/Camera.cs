using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camera : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        if(player.transform.position.y >= 0)
        {
            transform.position = new Vector3 (transform.position.x, player.transform.position.y, transform.position.z);
        }
    }
}
