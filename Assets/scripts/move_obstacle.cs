using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody obstacle;
    Vector3 velocity;
    private float speed  = 2000f;
   
    // Update is called once per frame
    void FixedUpdate()
    {
        obstacle.AddForce(0, 0, -speed * Time.deltaTime, ForceMode.Acceleration);
    }
}
