using UnityEngine;

public class movement_player : MonoBehaviour { 
    public Rigidbody rb;
    private float sideway_force_keyboard;
    private static float speed;
    private float xmov;
    public Vector3 _velocity;



    private void Start()
    {
        
        _velocity = Vector3.zero;
        speed = 3000f;
        sideway_force_keyboard = 1500f;
    }
    private void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * 30f, ForceMode.Acceleration);
        _velocity.z = speed * Time.fixedDeltaTime;
        if (!Left.isLeftpressed && !Right.isRightpressed && rb)
        {
            xmov = Input.GetAxis("Horizontal");
            _velocity.x = xmov * sideway_force_keyboard * Time.deltaTime;
            rb.velocity = _velocity;
            if (rb.position.y < -1f || rb.position.x < -11 || rb.position.x > 11)
            {
                FindObjectOfType<Game_manager>().EndGame();
            }
        }
        
    }
    public static void increase_speed()
    {
        speed += 30f;
    }
    public static void _boostSpeed()
    {
        speed += 1000f;
        return;
    }
    public static void _reduceSpeed()
    {
        speed -= 1000f;
        return;
    }

}