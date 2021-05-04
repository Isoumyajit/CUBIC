using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody obstacle;
    Vector3 velocity;
    private float speed  = 1000f;
    void Start()
    {
        velocity = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity.z = -speed * Time.deltaTime;
        obstacle.velocity = velocity;
    }
}
