
using UnityEngine;
using UnityEngine.SceneManagement;

public class PMenu : MonoBehaviour
{
    // The name of the main menu scene
    public string mainMenuSceneName = "Menu";

    // Update is called once per frame
    void Update()
    {
        // Check if the P key is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Load the main menu scene
            SceneManager.LoadScene(mainMenuSceneName);
        }
    }
}