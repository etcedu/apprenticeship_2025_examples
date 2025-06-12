using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject projectilePrefab;
    private int counter = 0;

    private PolygonCollider2D collider;
    private SpriteRenderer renderer;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<PolygonCollider2D>();
    }

    // FixedUpdate is called once per physics frame (50 times per second)
    void FixedUpdate()
    {
        counter++;
        if (counter >= 100)
        {
            collider.enabled = true;
            renderer.color = Color.white;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0f, speed, 0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position - new Vector3(0f, speed, 0f);
        }

        //if the player moves too far up, teleport them down
        if (transform.position.y > 6.25f)
        {
            transform.position = new Vector3(transform.position.x, -6f, 0f);
        }

        //if the player moves too far down, teleport them up
        if (transform.position.y < -6.25f)
        {
            transform.position = new Vector3(transform.position.x, 6f, 0f);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //On the frame the player hits the space bar...
            //Instantiate a projectile one space to the right of the player
            Instantiate(projectilePrefab, transform.position + new Vector3(1.4f, 0, 0), Quaternion.identity);
        }
    }
}
