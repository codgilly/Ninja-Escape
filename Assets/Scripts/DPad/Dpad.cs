using UnityEngine;

public class Dpad : MonoBehaviour
{
    public GameObject Player;

    private void Update()
    {
        if (Player == null)
        {
            print("No Player in DPad");
        }
    }

    public void Up()
    {
        print("up");
    }
    public void Left()
    {
        Debug.Log("Left");
    }
    public void Right()
    {
        print("Right");
    }
    public void Down()
    {
        print("Down");

    }
}
