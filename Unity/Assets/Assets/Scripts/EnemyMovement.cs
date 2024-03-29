using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private LayerMask platform;
    [SerializeField] private float movement_speed;
    private BoxCollider2D enemy_col;
    private Rigidbody2D enemy_rb;
    private float movement_direction;
    private void Awake()
    {
        enemy_col = GetComponent<BoxCollider2D>();
        enemy_rb = GetComponent<Rigidbody2D>();
        movement_direction = Random.Range(0, 2) == 0 ? -1 : 1;
    }
    private void FixedUpdate()
    {
        if(Physics2D.BoxCast(enemy_col.bounds.center, enemy_col.bounds.size, 0f, Vector2.right, 0.05f, platform) || Physics2D.BoxCast(enemy_col.bounds.center, enemy_col.bounds.size, 0f, Vector2.left, 0.05f, platform) || !Physics2D.BoxCast(enemy_col.bounds.center, new Vector2(enemy_col.bounds.size.x - 0.75f, enemy_col.bounds.size.y), 0f, Vector2.down, 0.05f, platform))
        {
            movement_direction *= -1;
        }
        enemy_rb.velocity = new Vector2(movement_speed * movement_direction, enemy_rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Kill")
        {
            movement_direction *= -1;
        }
    }
}