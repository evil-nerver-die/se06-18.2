using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToogleHandler : MonoBehaviour
{
    public Text Textfield;

    void Start() {
        Debug.Log("I am a toogle");
    }

    public void SetText(string text) {
        Textfield.text = "New Value : " + text;
    }
}
