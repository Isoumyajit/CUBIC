
using UnityEngine;
using UnityEngine.UI;

public class pausemenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject PausemenuUi;
    public GameObject game_overUi;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        isPaused = false;
        PausemenuUi.SetActive(false);
        Time.timeScale = 1f;
            
    }

    public void Pause()
    { 
            PausemenuUi.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
    }
}
