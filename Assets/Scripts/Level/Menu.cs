using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
       
        SceneManager.LoadSceneAsync("Level1"); // Load by scene name for clarity
        
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Stop the game in the editor
        #else
            Application.Quit(); // Quit the application in the build
        #endif
    }
}
