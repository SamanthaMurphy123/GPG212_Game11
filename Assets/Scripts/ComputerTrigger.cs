using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerTrigger : MonoBehaviour
{
    public Canvas canvasToShow; // The canvas to show
    private bool playerIsColliding = false; // Whether the player is currently colliding with the trigger
    public AudioSource audio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Only show the canvas if the player enters the trigger
        {
            playerIsColliding = true;
            canvasToShow.gameObject.SetActive(true); // Show the canvas
            audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Only hide the canvas if the player exits the trigger
        {
            playerIsColliding = false;
            canvasToShow.gameObject.SetActive(false); // Hide the canvas
        }
    }

    private void Update()
    {
        if (!playerIsColliding && canvasToShow.gameObject.activeSelf)
        {
            canvasToShow.gameObject.SetActive(false); // Hide the canvas if the player is not colliding with the trigger
        }
    }
}
