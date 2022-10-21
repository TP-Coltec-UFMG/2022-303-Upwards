using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float x, y;
    [SerializeField] private LayerMask platform, one_way;
    [SerializeField] private float jump_power, movement_speed, slide_speed;
    private BoxCollider2D player_col;
    private Rigidbody2D player_rb;
    private bool can_slide, can_turn, jump_request;
    private float movement_direction;
    private void Awake()
    {
        player_col = GetComponent<BoxCollider2D>();
        player_rb = GetComponent<Rigidbody2D>();
        can_slide = true;
        can_turn = true;
        jump_request = false;
        movement_direction = Random.Range(0, 2) == 0 ? -1 : 1;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(RequestJump());
        }
    }
    private void FixedUpdate()
    {
        if(State() == "Cornered")
        {
            can_slide = true;
            player_rb.gravityScale = 3f;
            if(can_turn)
            {
                can_turn = false;
                movement_direction *= -1f;
            }
        }
        else if(State() == "Grounded")
        {
            can_slide = true;
            can_turn = true;
            player_rb.gravityScale = 3f;
            if(jump_request)
            {
                jump_request = false;
                player_rb.velocity = new Vector2(player_rb.velocity.x, jump_power);
            }
        }
        else if(State() == "Sliding")
        {
            can_turn = true;
            player_rb.gravityScale = 0f;
            if(can_slide)
            {
                if(player_rb.velocity.y > -slide_speed + 0.05)
                {
                    player_rb.velocity = new Vector2(player_rb.velocity.x, player_rb.velocity.y - 3f);
                }
                else
                {
                    player_rb.velocity = new Vector2(player_rb.velocity.x, -slide_speed);
                }
            }
            if(jump_request)
            {
                can_slide = false;
                jump_request = false;
                movement_direction *= -1f;
                player_rb.velocity = new Vector2(player_rb.velocity.x, jump_power);
            }
        }
        else if(State() == "Airborne")
        {
            can_slide = true;
            can_turn = true;
            if(player_rb.velocity.y < 0)
            {
                player_rb.gravityScale = 5f;
            }
            else if(player_rb.velocity.y > 0 && !(Input.GetKey("space")))
            {
                player_rb.gravityScale = 8f;
            }
            else
            {
                player_rb.gravityScale = 3f;
            }
        }
        player_rb.velocity = new Vector2(movement_speed * movement_direction, player_rb.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Checkpoint")
        {
            x = collision.gameObject.transform.position.x;
            y = collision.gameObject.transform.position.y;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Kill")
        {
            player_rb.velocity = new Vector2(0f, 0f);
            transform.position = new Vector3(x, y, 0);
        }
    }
    private string State()
    {
        if(Physics2D.BoxCast(player_col.bounds.center, player_col.bounds.size, 0f, Vector2.down, 0.05f, platform))
        {
            if(Physics2D.BoxCast(player_col.bounds.center, player_col.bounds.size, 0f, Vector2.left, 0.05f, platform) || Physics2D.BoxCast(player_col.bounds.center, player_col.bounds.size, 0f, Vector2.right, 0.05f, platform))
            {
                return "Cornered";
            }
            else
            {
                return "Grounded";
            }
        }
        else if(Physics2D.BoxCast(player_col.bounds.center, player_col.bounds.size, 0f, Vector2.down, 0.05f, one_way))
        {
            if(Physics2D.BoxCast(player_col.bounds.center, player_col.bounds.size, 0f, Vector2.left, 0.05f, platform) || Physics2D.BoxCast(player_col.bounds.center, player_col.bounds.size, 0f, Vector2.right, 0.05f, platform))
            {
                return "Cornered";
            }
            else
            {
                return "Grounded";
            }
        }
        else if(Physics2D.BoxCast(player_col.bounds.center, player_col.bounds.size, 0f, Vector2.left, 0.05f, platform) || Physics2D.BoxCast(player_col.bounds.center, player_col.bounds.size, 0f, Vector2.right, 0.05f, platform))
        {
            return "Sliding";
        }
        else
        {
            return "Airborne";
        }
    }
    private IEnumerator RequestJump()
    {
        jump_request = true;
        yield return new WaitForSeconds(0.175f);
        jump_request = false;
    }
}