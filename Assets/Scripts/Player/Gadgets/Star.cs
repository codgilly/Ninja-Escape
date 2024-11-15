using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject star;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shooting()
    {
        star.active = true;

        RaycastHit rayHit;
        Debug.DrawRay(transform.position, transform.forward, Color.green);

        if (Physics.Raycast(transform.position, transform.forward, out rayHit))
        {
            star.transform.position = rayHit.point;
        }
    }
}
