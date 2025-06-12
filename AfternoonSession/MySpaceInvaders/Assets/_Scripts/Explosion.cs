using UnityEngine;

public class Explosion : MonoBehaviour
{
    private int counter = 0;

    private void FixedUpdate()
    {
        counter++;
        if (counter > 25)
        {
            Destroy(gameObject);
        }
    }
}
