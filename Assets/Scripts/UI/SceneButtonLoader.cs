using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonLoader : MonoBehaviour
{
    // Load Gameplay Scene
    public void LoadGame()
    {
        SceneManager.LoadScene("1");
    }

    // Load Main Menu
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // Quit Game (optional)
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
