
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
         if(score_display == 20f || score_display == 50f|| score_display == 70f || score_display == 100f || score_display == 120f || score_display == 150f)
            {
                movement_player.increase_speed();
            }
         scoreText.text = score_display.ToString("0");
        }
    }
}
