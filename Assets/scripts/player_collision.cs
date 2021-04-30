
using UnityEngine;

public class player_collision : MonoBehaviour
{
    /*
    private movement_player move;
    private Left Left_key;
    private Right Right_key;
    */

    public GameObject destroyEffect;
    public Rigidbody rb;
      public void OnCollisionEnter (Collision collisionInfo){
            if(collisionInfo.collider.tag == "Obstacle"){

            Instantiate(destroyEffect, rb.position, Quaternion.identity, transform);
             FindObjectOfType<Game_manager>().EndGame();
            
        }
      }

}
