using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FlyingEnemyMovement : MonoBehaviour
{
    [SerializeField] private LayerMask platform;
    [SerializeField] private float movement_distance, movement_speed;
    private BoxCollider2D enemy_col;
    private Rigidbody2D enemy_rb;
    private float distance_left, distance_right, movement_direction;
    private void Awake()
    {
        enemy_col = GetComponent<BoxCollider2D>();
        enemy_rb = GetComponent<Rigidbody2D>();
        movement_direction = Random.Range(0, 2) == 0 ? -1 : 1;
    }
    private void Start()
    {
        distance_left = transform.position.x - movement_distance;
        distance_right = transform.position.x + movement_distance;
    }
    private void FixedUpdate()
    {
        if(transform.position.x < distance_left || transform.position.x > distance_right)
        {
            movement_direction *= -1;
        }
        if(Physics2D.BoxCast(enemy_col.bounds.center, enemy_col.bounds.size, 0f, Vector2.right, 0.05f, platform) || Physics2D.BoxCast(enemy_col.bounds.center, enemy_col.bounds.size, 0f, Vector2.left, 0.05f, platform))
        {
            movement_direction *= -1;
        }
        enemy_rb.velocity = new Vector2(movement_speed * movement_direction, enemy_rb.velocity.y);
    }
}