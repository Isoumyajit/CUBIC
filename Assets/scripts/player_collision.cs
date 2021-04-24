
using UnityEngine;

public class player_collision : MonoBehaviour
{
     
      public movement_player movement;
      public Game_manager game_obj;

      public void OnCollisionEnter (Collision collisionInfo){
            if(collisionInfo.collider.tag == "Obstacle"){
                  movement.enabled = false;
                  FindObjectOfType<Game_manager>().EndGame();
            }
      }

}
