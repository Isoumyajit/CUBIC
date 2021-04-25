
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
         if(Game_manager.game_over == false){
         score_display += 0.01f;
         scoreText.text = score_display.ToString("0");
        }
    }
}
