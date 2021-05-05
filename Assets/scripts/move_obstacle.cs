using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody obstacle;
    Vector3 velocity;
    private float speed;
    private float speed_sidemove;
    private float maxTransform;
    private float minTransform;
    private float direction = 1;
    private bool isleft = true;
    private bool isright = false;

    private void Start()
    {
        speed = 200f;
        speed_sidemove = 5f;
        maxTransform = -5f;
        minTransform = 5f;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(obstacle.name);
        
        if(obstacle.name == "Sphere(Clone)")
        {
            obstacle.transform.Rotate(0f, 360f, 0f);
            obstacle.transform.Translate(speed_sidemove * direction * Time.deltaTime, 0, 0);
            checkDirection();
            Debug.Log((int)obstacle.transform.position.x);
        }
        else
        {
            obstacle.AddForce(0, 0, -speed * Time.deltaTime, ForceMode.Acceleration);
        }
    }

    public void checkDirection()
    {
        Debug.Log("working");

        if ((int)obstacle.transform.position.x >= maxTransform && isleft)
        {

            direction = -1;
            if ((int)obstacle.transform.position.x == maxTransform)
            {
                isleft = false;
                isright = true;
            }

        }

        else if ((int)obstacle.transform.position.x <= minTransform && isright)
        {

            direction = 1;
            if((int)obstacle.transform.position.x == minTransform)
            {
                isleft = true;
                isright = false;
            }
        }

    }

    public void increaseobstacleMoveSpeed()
    {
        speed += 10f;
        speed_sidemove += 100f;

    }

}
