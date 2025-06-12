using UnityEngine;

public class Explosion : MonoBehaviour
{
    public int countMax;
    private int counter = 0;

    private void FixedUpdate()
    {
        counter++;

        //if two seconds have passed since this explosion began existing
        if (counter > countMax)
        {
            Destroy(gameObject);
        }
    }
}
