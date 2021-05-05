
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
    private int High_score;
    public GameObject _celebrationPrefab;
    public GameObject palyer;
    public GameObject Score;

    private void Start()
    {
        High_score = PlayerPrefs.GetInt("Highest_score", 0);
    }

    private void Update()
    {
       if(High_score < score.score_display)
        {
            Instantiate(_celebrationPrefab, palyer.transform.position , Quaternion.identity, transform);
        } 
    }
    public void EndGame(){

        if(game_over == false){
            game_over = true;
            Debug.Log("Game Over");
            Invoke("Trigger_restart_btn", restartDelay);
        }
    }

    public void Trigger_restart_btn(){

        Score.SetActive(false);
        Controller.SetActive(false);
        Lft.SetActive(false);
        Rht.SetActive(false);
        Pause.SetActive(false);
        High_score = PlayerPrefs.GetInt("Highest_score", 0);
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
        game_over = false;
        pausemenu.isPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   
    }
    public void back_to_main(){
        game_over = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
