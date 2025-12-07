using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // <-- You MUST include this line!

public class SceneLoader : MonoBehaviour
{
    // These need to match the names in your Build Settings exactly.
    // Since your game scene is named Portaly_finished, we use that.
    public string gameSceneName = "Partially_finished";

    // Since your main menu is named HomeMenu, we use that.
    public string homeSceneName = "Home Menu";

    // Function called by the 'Play' button
    public void LoadGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    // Function called by the 'Home' button (from Game Over screen)
    public void LoadHomeMenu()
    {
        SceneManager.LoadScene(homeSceneName);
    }

    // Function called by the 'Exit Game' button
    public void QuitGame()
    {
        // This command closes the application (only works in a built game).
        Application.Quit();

        // This is just a message to show it worked when testing in the Unity Editor.
        Debug.Log("Game Exited (If running as a build)");
    }
}