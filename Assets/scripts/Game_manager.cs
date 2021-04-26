
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Game_manager : MonoBehaviour
{

    public float restartDelay = 2f;
    public static bool game_over = false;
    public GameObject Game_Restrart_btn;
    public GameObject Controller;
    public Text score_display;

    public void EndGame(){

        
        if(game_over == false){
            game_over = true;
            Debug.Log("Game Over");
            //restart the game
            Invoke("Trigger_restart_btn", restartDelay);
        }
    }

    public void Trigger_restart_btn(){
        Controller.SetActive(false);
        Game_Restrart_btn.SetActive(true); 
        score_display.text = score.score_display.ToString("0"); 
    }
    public void TriggerRestartbtn(){
        Game_manager.game_over = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void back_to_main(){
        Game_manager.game_over = false;
        score.score_display = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
