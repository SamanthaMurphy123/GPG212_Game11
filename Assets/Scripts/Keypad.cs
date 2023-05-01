using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ans;
    [SerializeField] private Animator door;


    private string answer = "123456";
    public void Number(int number)
    {
        ans.text += number.ToString();
    }

    public void Execute()
    {
        if (ans.text == answer)
        {
            ans.text = "CORRECT";
            door.SetBool("Open", true);
        }
        else
        {
            ans.text = "INVALID";
        }
    }

}
