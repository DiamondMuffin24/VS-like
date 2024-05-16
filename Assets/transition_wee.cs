using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition_wee : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("rock"))
        {
            SceneManager.LoadScene("Hidden_horror");
        }
            
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("rock"))
        {
            SceneManager.LoadScene("Inside_House");
        }

    }
}
