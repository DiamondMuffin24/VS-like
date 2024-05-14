using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGame : MonoBehaviour
{
    
    public string Game_one; // Name of the next scene to load

    // This method is called when the button is clicked
    public void LoadNextScene()
    {
        SceneManager.LoadScene(Game_one);
    }
}
