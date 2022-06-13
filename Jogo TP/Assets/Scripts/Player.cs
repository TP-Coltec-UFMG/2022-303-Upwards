using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public Rigidbody2D player_rb;
    public float speed;
    private float direction;
    public BoxCollider2D player_col;
    [SerializeField] private LayerMask Ground;
    public float jump;
    private bool sliding;
    private void Start()
    {
        direction = Random.Range(0, 2) == 0 ? -1 : 1;
        sliding = false;
    }
    void Update()
    {
        player_rb.velocity = new Vector2(speed * direction, player_rb.velocity.y);
        if(Input.GetKey("space") && IsGrounded())
        {
            player_rb.velocity = new Vector2(player_rb.velocity.x, jump);
        }
        if(sliding)
        {
            if(IsGrounded())
            {
                direction *= -1;
                sliding = false;
            }
            if(Input.GetKey("space"))
            {
                direction *= -1;
                player_rb.velocity = new Vector2(player_rb.velocity.x, jump);
                sliding = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            if(IsGrounded())
            {
                direction *= -1;
            }
            else
            {
                sliding = true;
            }
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(player_col.bounds.center, player_col.bounds.size, 0f, Vector2.down, .1f, Ground);
    }
}