
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Game_manager : MonoBehaviour
{
    public float restartDelay = 2f;
    public static bool game_over = false;
    public GameObject Game_Restrart_btn;
    public GameObject Controller;
    public GameObject Lft;
    public GameObject Rht;
    public GameObject Pause;
    public Text score_display;
    public GameObject Ui;
    public Text HighScore;
    int High_score;

    private void Start()
    {
        High_score = PlayerPrefs.GetInt("Highest_score", 0);
    }
    public void EndGame(){

        if(game_over == false){
            Game_manager.game_over = true;
            Debug.Log("Game Over");
            Invoke("Trigger_restart_btn", restartDelay);
        }
    }

    public void Trigger_restart_btn(){
        Controller.SetActive(false);
        Lft.SetActive(false);
        Rht.SetActive(false);
        Pause.SetActive(false);
        int High_score = PlayerPrefs.GetInt("Highest_score", 0);
        int score_current = int.Parse(score.score_display.ToString("0"));
        Debug.Log(score_current +" " + High_score);
        if (score_current > High_score)
            PlayerPrefs.SetInt("Highest_score", score_current);

        Game_Restrart_btn.SetActive(true);

        HighScore.text = PlayerPrefs.GetInt("Highest_score").ToString();
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
        Left.isLeftpressed = false;
        Right.isRightpressed = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   
    }
    public void back_to_main(){
        Game_manager.game_over = false;
        score.score_display = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
