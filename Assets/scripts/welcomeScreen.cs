
using UnityEngine;
using UnityEngine.SceneManagement;

public class welcomeScreen : MonoBehaviour
{
         public GameObject credit_screen;
         public GameObject welcomemenu;

         public void StartGame(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void EndGame(){
            Application.Quit();
        }
}
