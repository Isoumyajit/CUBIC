using System.Collections;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    //public GameObject __powereffectspeedUp;
    public Rigidbody rb;
    private Game_manager game_obj;

    private float cubeSize = 0.2f;
    private int cubesInRow = 5;

    private float cubesPivotDistance;
    Vector3 cubesPivot;

    private float explosionForce = 10f;
    private float explosionRadius = 5f;
    private float explosionUpward = 0.4f;




    private bool isActivePower = false;
    public void OnCollisionEnter (Collision collisionInfo){
            if(collisionInfo.collider.tag == "Obstacle" && rb){
            explode();
            FindObjectOfType<Game_manager>().EndGame();
        }
            if(collisionInfo.collider.name == "Bottle_Speed_Up" && !isActivePower && rb)
        {
            Destroy(collisionInfo.collider.gameObject);
            //Instantiate(__powereffectspeedUp, __powereffectspeedUp.transform.position, Quaternion.identity, transform);
            Debug.Log(collisionInfo.collider.tag);
            isActivePower = true;
            StartCoroutine(PowerUpWearOff(5f));
            
        }
      }

    public void explode()
    {
        //make object disappear
        gameObject.SetActive(false);

        //loop 3 times to create 5x5x5 pieces in x,y,z coordinates
        for (int x = 0; x < cubesInRow; x++)
        {
            for (int y = 0; y < cubesInRow; y++)
            {
                for (int z = 0; z < cubesInRow; z++)
                {
                    createPiece(x, y, z);
                }
            }
        }

        //get explosion position
        Vector3 explosionPos = transform.position;
        //get colliders in that position and radius
        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);
        //add explosion force to all colliders in that overlap sphere
        foreach (Collider hit in colliders)
        {
            //get rigidbody from collider object
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                //add explosion force to this body with given parameters
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, explosionUpward);
            }
        }

    }

    void createPiece(int x, int y, int z)
    {

        //create piece
        GameObject piece;
        piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //set piece position and scale
        piece.transform.position = transform.position + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z) - cubesPivot;
        piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);

        //add rigidbody and set mass
        piece.GetComponent<Renderer>().material.color = rb.GetComponent<Renderer>().material.color;
        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = cubeSize;
    }
    IEnumerator PowerUpWearOff(float waitTime)
    {
        Debug.Log("yes power up");
        movement_player._boostSpeed();
        yield return new WaitForSeconds(waitTime);
        movement_player._reduceSpeed();
        isActivePower = false;
    }

}
