
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_manager : MonoBehaviour
{

    public float restartDelay = 2f;
    public static bool game_over = false;
    public GameObject Game_Restrart_btn;

    public void EndGame(){

        if(game_over == false){
            game_over = true;
            Debug.Log("Game Over");
            //restart the game
            Invoke("Trigger_restart_btn", restartDelay);
        }
    }

    public void Trigger_restart_btn(){
        Game_Restrart_btn.SetActive(true);  
    }
    public void TriggerRestartbtn(){
        Game_manager.game_over = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
