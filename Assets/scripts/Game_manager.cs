
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Game_manager : MonoBehaviour
{
    private Rigidbody rb;
    public float restartDelay = 2f;
    public static bool game_over = false;
    public GameObject Game_Restrart_btn;
    public GameObject Controller;
    public GameObject Lft;
    public GameObject Rht;
    public GameObject Pause;
    public Text score_display;
    public GameObject Ui;
   
    public void EndGame(){

        if(game_over == false){
            Game_manager.game_over = true;
            Debug.Log("Game Over");
            //restart the game
            //Destroy(rb);
            Invoke("Trigger_restart_btn", restartDelay);
        }
    }

    public void Trigger_restart_btn(){
        Controller.SetActive(false);
        Lft.SetActive(false);
        Rht.SetActive(false);
        Pause.SetActive(false);
        Game_Restrart_btn.SetActive(true); 
        score_display.text = score.score_display.ToString("0"); 
    }
    public void TriggerRestartbtn(){

        if (!game_over)
        {
            Time.timeScale = 1f;
        }
        Ui.SetActive(false);
        score.score_display = 0f;
        Game_manager.game_over = false;
        pausemenu.isPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   
    }
    public void back_to_main(){
        Game_manager.game_over = false;
        score.score_display = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
