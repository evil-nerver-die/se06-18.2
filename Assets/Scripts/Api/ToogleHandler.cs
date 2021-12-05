using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToogleHandler : MonoBehaviour
{
    public Text Textfield;

    void Start() {
        string jsonResponse = ApiHelper.getApiData("http://localhost:3000/stars/1");
        int data = getStar(jsonResponse);
        Debug.Log("All coin: " + data);
    }

    public void SetText(string text) {
        string jsonResponse = ApiHelper.getApiData("http://localhost:3000/stars/1");
        int data = getStar(jsonResponse);
        Textfield.text = "All star: " + data;
    }

    public static int getStar(string jsonData) {
        Star starObj = JsonUtility.FromJson<Star>(jsonData);
        return starObj.count;
    }
}
