using UnityEngine;

public class movement_player : MonoBehaviour
{
    public Rigidbody rb;
    public float forward_force = 700f;
    public float sideway_force = 40f;
    public float sideway_force_mobile = 60f;
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
        // if (Input.GetKey("w")){
        //     rb.AddForce(0, 0, 2000*Time.deltaTime, ForceMode.VelocityChange);
        // }

        // if (Input.GetKey("space")){
        //     rb.AddForce(0, sideway_force * Time.deltaTime, 0, ForceMode.VelocityChange);
        // }

        if(rb.position.y < -1f){
            FindObjectOfType<Game_manager>().EndGame();
        }
    }
    //for mobile input

    public void moveLeft(){
        rb.AddForce(-sideway_force_mobile * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void moveRight(){
         rb.AddForce(sideway_force_mobile * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

}