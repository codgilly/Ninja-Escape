using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject star;
    Rigidbody2D rb;

    public float floatHeight;
    public float liftForce;
    public float damping;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Shoot()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);

        print(hit.collider.tag);

        if (hit.collider == null)
        {
            float distance = Mathf.Abs(hit.point.y - transform.position.y);
            float heightError = floatHeight - distance;

            float force = liftForce * heightError - rb.linearVelocity.y * damping;

            // Apply the force to the rigidbody.
            rb.AddForce(Vector3.up * force);
        }
    }

}
