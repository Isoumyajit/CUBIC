using UnityEngine;

public class movement_player : MonoBehaviour { 
    public Rigidbody rb;
    private float sideway_force_keyboard = 1700f;
    public static float speed = 3000f;
    private float xmov;
    public Vector3 _velocity;

    private void Start()
    {
        _velocity = Vector3.zero;
    }
    private void FixedUpdate()
    {
        _velocity.z = speed * Time.fixedDeltaTime;
        if (!Left.isLeftpressed && !Right.isRightpressed)
        {
            xmov = Input.GetAxis("Horizontal");
            _velocity.x = xmov * sideway_force_keyboard * Time.deltaTime;
            rb.velocity = _velocity;
            if (rb.position.y < -1f || rb.position.x < -10 || rb.position.x > 10)
            {
                FindObjectOfType<Game_manager>().EndGame();
            }
        }
        
    }
    public static void increase_speed()
    {
        speed += 1000f;
        Left.speed += 1000f;
        Right.speed += 1000f;
        Debug.Log("comes here yes " + speed);
    }
}