using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Rigidbody rb;
    private float sideway_force;
    private Vector3 _velocity;

    public static bool isRightpressed = false;
    private void Start()
    {
        _velocity = Vector3.zero;
        sideway_force = 1700f;
    }
    private void FixedUpdate()
    {

        if (rb)
        {
            if (isRightpressed)
            {
                _velocity.x = sideway_force * Time.deltaTime;
                rb.velocity = _velocity;
            }
            if (rb.position.y < -1f || rb.position.x < -11 || rb.position.x > 11)
            {
            
                FindObjectOfType<Game_manager>().EndGame();
            }
        }

    }
    public void OnPointerDown(PointerEventData evenData)
    {
     
        isRightpressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isRightpressed = false;
    }
}
