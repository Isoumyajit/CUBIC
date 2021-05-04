
using UnityEngine;

public class follow_player : MonoBehaviour
{
    public Transform Game_player;
    public Vector3 offset;
  
    // Update is called once per frame
    void Update()
    {
            if(Game_player)
                transform.position = Game_player.position + offset;
            else
            {
            transform.position = offset;
            }
    }
}
 