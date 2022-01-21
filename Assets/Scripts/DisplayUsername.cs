using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUsername : MonoBehaviour
{

    //TextMeshProUGUI outputArea;
    public Text Textfield;
    // Start is called before the first frame update
    public void Start()
    {
        //outputArea = GameObject.Find("Output").GetComponent<TextMeshProUGUI>();
        string username = ReadText.getUsername();                    
        
        //outputArea.text = "Hello, " + username;
        Textfield.text = "Hello, " + username;
        Debug.Log(username);
    }
}