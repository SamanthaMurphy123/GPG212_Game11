using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggle : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2; 

    private bool panel1Visible = true;
    private bool panel2Visible = true; 

    // Attach this method to the button's onClick event in the Unity editor
    public void ToggleHintVisibility()
    {
        panel1Visible = !panel1Visible; // Invert the visibility flag
        panel1.SetActive(panel1Visible); // Set the panel's visibility based on the flag
        panel2.SetActive(false);
    }

    public void ToggleNoteVisibility()
    {
        panel2Visible = !panel2Visible; // Invert the visibility flag
        panel2.SetActive(panel2Visible); // Set the panel's visibility based on the flag
        panel1.SetActive(false);
    }

}
