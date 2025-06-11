using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get the rigidbody for use later
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //every physics frame, set the velocity to move to the right
        rb.linearVelocityX = speed;

        //if the projectile is far away, destroy it
        if (transform.position.x > 15)
        {
            Destroy(gameObject);
        }
    }
}
