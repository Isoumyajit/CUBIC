using UnityEngine;

public class movement_player : MonoBehaviour
{
    public Rigidbody rb;
    private float sideway_force = 1500f;
    private float sideway_force_mobile = 60f;
    private float speed = 3000f;
    private float xmov, ymov, zmov;
    private Vector3 _velocity;

    // Update is called once per frame
    //FixedUpdate is used for playing with physics
    private void Start()
    {
        _velocity = Vector3.zero;
    }
    private void FixedUpdate()
    {
        /*
        Vector3 Moveforward = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + Moveforward);

        Vector3 X_axis_move = transform.right * xmov * sideway_force * Time.fixedDeltaTime * 2;
        rb.MovePosition(rb.position + Moveforward + X_axis_move);
        */

        rb.velocity = _velocity;

        if (rb.position.y < -1f){
            FindObjectOfType<Game_manager>().EndGame();
        }
    }

    private void Update()
    {
        xmov = Input.GetAxis("Horizontal");
        if (score.score_display >= 50 || score.score_display >= 70 || score.score_display >= 100 || score.score_display >= 150 || score.score_display >= 120)
        {
            speed += 5f;
        }
        _velocity.z = speed * Time.fixedDeltaTime;
        _velocity.x = sideway_force * Time.fixedDeltaTime * xmov;
    }
    //for mobile input

    public void moveLeft(){
        rb.AddForce(-sideway_force_mobile * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void moveRight(){
         rb.AddForce(sideway_force_mobile * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

}