using UnityEngine;

public class SmokeBomb : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.enabled)
        {
            Invoke("Disapear", 3f);
        }

        if (!this.enabled)
        {
            
        }

    }

    void Disapear()
    {
        this.gameObject.SetActive(false);
    }
}
