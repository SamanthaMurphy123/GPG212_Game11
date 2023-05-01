using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OpenLeftDoor : MonoBehaviour
{
    private Animator anim;

    private bool IsAtDoor = false;

    string codeTextValue = "";
    public string safeCode = "12345";
    public GameObject codePanel;
    [SerializeField] private TextMeshProUGUI ans;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (codeTextValue.Length >= 5)
        {
            codeTextValue = "";
        }

        if(IsAtDoor == true)
        {
            codePanel.SetActive(true);  
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            IsAtDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsAtDoor = false;
        codePanel.SetActive(false);
    }


    public void Number(int number)
    {
        ans.text += number.ToString();
    }

    public void Execute()
    {
       // ans.text = codeTextValue;

        if (ans.text == safeCode)
        {
            ans.text = "CORRECT";
            SceneManager.LoadScene("EndScene");
            anim.SetTrigger("OpenLeftDoor");
            codePanel.SetActive(false);
        }
        if (ans.text != safeCode)
        {
            ans.text = "INVALID";
            ans.text = "";
        }
    }

}
