using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    
    public string Hidden_horror; // Name of the scene to transition to

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("workplz");
            SceneManager.LoadScene(Hidden_horror); // Load the specified scene
        }
    }
}
