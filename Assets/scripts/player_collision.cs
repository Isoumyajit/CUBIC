
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
    private Game_manager game_obj;
      public void OnCollisionEnter (Collision collisionInfo){
            if(collisionInfo.collider.tag == "Obstacle" && rb){
            rb.velocity += new Vector3(0, 0, -70000f);
            Instantiate(destroyEffect, rb.position, Quaternion.identity, transform);
            Destroy(gameObject, 2f);
            FindObjectOfType<Game_manager>().EndGame();
        }
      }

}
