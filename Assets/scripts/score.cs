
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Game_player;
    public Text scoreText;
    public static float score_display;
    public bool check_gameOver;
    
    // Update is called once per frame
    void Start(){
        score_display = 0f;
        scoreText.text = score_display.ToString("0");
    }
    void Update()
    {
         if(Game_manager.game_over == false && !pausemenu.isPaused){
         score_display += 0.05f;
          int score_checker = (int)score_display;
         if(score_checker == 20 || score_checker == 50 || score_checker == 70 || score_checker == 100 || score_checker == 120f || score_checker == 150)
            {
                movement_player.increase_speed();
            }
            
            scoreText.text = score_display.ToString("0");
        }
    }

}
