using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called once per fixed frame
    void FixedUpdate()
    {
        rb.linearVelocityX = -speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided!");
        if (collision.collider.CompareTag("Player"))
        {
            //If the enemy bumps into the player, kill the player
            Destroy(collision.collider.gameObject);
        }

        if (collision.collider.CompareTag("Projectile"))
        {
            //If the enemy bumps into a projectile, kill this enemy and the projectile
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
    }
}
