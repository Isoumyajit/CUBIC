using UnityEngine;
using UnityEngine.EventSystems;
public class Left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Rigidbody rb;
    public float sideway_force = 500f;
    public static float speed = 3000f;
    public Vector3 _velocity;
    public static bool isLeftpressed = false;

    // Update is called once per frame
    //FixedUpdate is used for playing with physics
    private void Start()
    {
        _velocity = Vector3.zero;
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
            if (rb.position.y < -1f || rb.position.x < -10 || rb.position.x > 10)
            {

                FindObjectOfType<Game_manager>().EndGame();
            }
        }
        
    }
    public void OnPointerDown(PointerEventData evenData)
    {
        Debug.Log("yes");
        isLeftpressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isLeftpressed = false;
    }

}