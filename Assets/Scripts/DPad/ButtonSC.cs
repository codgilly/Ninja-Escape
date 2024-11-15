using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSC : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public GameObject player;
    public float xv, yv;

    void Start()
    {
    }

    void Update()
    {
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if( xv > 0 )
        {
            player.GetComponent<PlayerSC>().right = true;
        }
        if (xv < 0)
        {
            player.GetComponent<PlayerSC>().left = true;
        }
        if (yv > 0)
        {
            player.GetComponent<PlayerSC>().up = true;
        }
        if (yv < 0)
        {
            player.GetComponent<PlayerSC>().down = true;
        }



    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (xv > 0)
        {
            player.GetComponent<PlayerSC>().right = false;
        }
        if (xv < 0)
        {
            player.GetComponent<PlayerSC>().left = false;
        }
        if (yv > 0)
        {
            player.GetComponent<PlayerSC>().up = false;
        }
        if (yv < 0)
        {
            player.GetComponent<PlayerSC>().down = false;
        }

    }
}
