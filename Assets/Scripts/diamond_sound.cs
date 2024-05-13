using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond_sound : MonoBehaviour
{
    
    public AudioClip pickupSound; // Reference to the sound effect
    private AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        // If there's no AudioSource component, add one
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player (or any other GameObject with a specific tag) is colliding with the item
        if (other.CompareTag("Player"))
        {
            // Play the pickup sound effect
            if (pickupSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(pickupSound);
            }
        }
    }
}
