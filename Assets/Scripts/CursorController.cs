using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    private void Start()
    {
        // Lock the cursor to the game window and hide it
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
