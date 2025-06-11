using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get the Rigidbody2D component and save it to use later
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //on every physics frame, set velocity to the left
        rb.linearVelocityX = -speed;

        //if the enemy is far away, destroy it
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            //If the enemy runs into the player, kill the player
            Destroy(collision.collider.gameObject);
        }
        if (collision.collider.CompareTag("Projectile"))
        {
            //If the enemy runs into a projectile, kill the enemy and the projectile
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
        
    }


}
