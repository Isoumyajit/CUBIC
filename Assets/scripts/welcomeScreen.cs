
using UnityEngine;
using UnityEngine.SceneManagement;

public class welcomeScreen : MonoBehaviour
{
         public GameObject credit_screen;
         public GameObject welcomemenu;

         public void StartGame(){
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void EndGame(){
            Application.Quit();
        }
}
