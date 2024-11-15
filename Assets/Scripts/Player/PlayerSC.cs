using UnityEngine;

public class PlayerSC : MonoBehaviour
{
    public bool up,down,left,right;

    Rigidbody2D rb;
    SpriteRenderer sr;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.linearVelocity = new Vector2(0, 0);
        if (up)
        {
            sr.transform.rotation = Quaternion.Euler(0, 0, 0);
            rb.linearVelocity = new Vector2(0, 4);
        }
        if (down)
        {
            sr.transform.rotation = Quaternion.Euler(0, 0, -180);
            rb.linearVelocity = new Vector2(0, -4);
        }
        if (left)
        {
            sr.transform.rotation = Quaternion.Euler(0, 0, 90);
            rb.linearVelocity = new Vector2(-4, 0);
        }
        if (right)
        {
            sr.transform.rotation = Quaternion.Euler(0, 0, -90);
            rb.linearVelocity = new Vector2(4, 0);
        }

        //up = false;
        //down = false;
        //left = false;
        //right = false;

    }
}
