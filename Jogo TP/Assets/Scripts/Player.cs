using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public Rigidbody2D player_rb;
    public BoxCollider2D player_col;
    [SerializeField] private LayerMask Ground;
    public float speed;
    public float jump;
    private float direction;
    private void Start()
    {
        direction = Random.Range(0, 2) == 0 ? -1 : 1;
    }
    private void Update()
    {
        player_rb.velocity = new Vector2(direction * speed, player_rb.velocity.y);
        if(Input.GetKeyDown("space") && IsGrounded())
        {
            player_rb.velocity = new Vector2(player_rb.velocity.x, jump);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            direction *= -1;
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(player_col.bounds.center, player_col.bounds.size, 0f, Vector2.down, .1f, Ground);
    }
}