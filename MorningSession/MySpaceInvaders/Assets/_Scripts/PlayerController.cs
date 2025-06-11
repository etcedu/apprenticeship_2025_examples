using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject projectilePrefab;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, speed, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position - new Vector3(0, speed, 0);
        }
    }

    private void Update()
    {
        //If the player hits the space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //spawn a projectile
            Instantiate(projectilePrefab, transform.position + new Vector3(1,0,0), Quaternion.identity);
        }
    }
}
