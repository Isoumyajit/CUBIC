using UnityEngine;
using UnityEngine.EventSystems;
public class Left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Rigidbody rb;
    private float sideway_force;
    private Vector3 _velocity;
    public static bool isLeftpressed;
    private float speed;

    // Update is called once per frame
    //FixedUpdate is used for playing with physics
    private void Start()
    {
        _velocity = Vector3.zero;
        sideway_force = 1700f;
        speed = 3000f;
        isLeftpressed = false;
    }
    private void FixedUpdate()
    {
        _velocity.z = speed * Time.fixedDeltaTime;
        if (rb)
        {
            if (isLeftpressed)
            {
                _velocity.x = -sideway_force * Time.deltaTime;
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
 
        isLeftpressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isLeftpressed = false;
    }
}