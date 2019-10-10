using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //public int health = 0;
    //public Text healthDisplay;
    public Text score;
    public int scoreValue = 0;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    bool facingRight = true;

    Vector2 movement;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        //healthDisplay.text = health.ToString();
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    void LateUpdate()
    {
        
        Vector3 localScale = transform.localScale;
        if (movement.x > 0 && !facingRight)
        {
            Flip();
        }
        else if (movement.x < 0 && facingRight)
        {
            Flip();
        }
    }
    //void SetHealth()
    //{
    //    healthDisplay.text = "Health : " + health;
    //}
    void Flip()
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "pacdot")
        {
            collision.gameObject.SetActive(false);
            scoreValue += 10;
            SetScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("enemy"))
            GameControllerScript.health -= 1;
    }
    void SetScore()
    {
        score.text = "Score: " + scoreValue;
    }
}
