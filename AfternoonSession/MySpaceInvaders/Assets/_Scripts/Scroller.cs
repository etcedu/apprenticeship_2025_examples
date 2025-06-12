using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float scrollSpeed;
    public Transform background, background2;
    private float backgroundWidth;

    private void Start()
    {
        backgroundWidth = background.GetComponent<SpriteRenderer>().bounds.size.x;
        background2.position = background.position + transform.right * backgroundWidth;
    }

    private void FixedUpdate()
    {
        background.Translate(Vector3.left*scrollSpeed);
        background2.Translate(Vector3.left*scrollSpeed);

        //if our first background is too far to the left
        if (background.position.x < -19)
        {
            //snap the position of the first background to the right of the second one
            background.position = background2.position + transform.right * backgroundWidth;
        }

        //if our second background is too far to the left
        if (background2.position.x < -19)
        {
            //snap the position of the second background to the right of the first one
            background2.position = background.position + transform.right * backgroundWidth;
        }
    }


}
