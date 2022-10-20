using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Kill : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if(Collision.gameObject.name == "Player")
        {
            Collision.gameObject.transform.position = new Vector3(0, -6, 0);
        }
    }
}
