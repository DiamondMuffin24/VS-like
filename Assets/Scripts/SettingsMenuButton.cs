
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenuButton : MonoBehaviour
{
    // The name of the settings scene
    public string settingsSceneName = "Settings";

    // This function is called when the button is pressed
    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene(settingsSceneName);
    }
}