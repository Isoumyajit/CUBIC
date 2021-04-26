
using UnityEngine;

public class movement_player : MonoBehaviour
{
    public Rigidbody rb;
    public float forward_force = 2000f;
    public float sideway_force = 10f;
    public Game_manager game_obj;
    
    // Update is called once per frame
    //FixedUpdate is used for playing with physics

    void FixedUpdate()
    {
        // add a forward force 
        rb.AddForce(0, 0 , forward_force * Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(sideway_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")){
            rb.AddForce(-sideway_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // if (Input.GetKey("space")){
        //     rb.AddForce(0, sideway_force * Time.deltaTime, 0, ForceMode.VelocityChange);
        // }

        if(rb.position.y < -1f){
            FindObjectOfType<Game_manager>().EndGame();
        }
    }
}
