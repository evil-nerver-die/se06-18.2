
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;


using TMPro;
public class GetMethod : MonoBehaviour
{

    TextMeshProUGUI outputArea;
    // Start is called before the first frame update
    void Start()
    {
        outputArea = GameObject.Find("Output").GetComponent<TextMeshProUGUI>();
        string jsonResponse = ApiHelper.getApiData("https://lmh-json-api.herokuapp.com/coins");
        JSONNode itemsData = JSON.Parse(jsonResponse);
        string coinText = "User: " + itemsData[0]["userId"] + " - score: " + itemsData[0]["count"] + "\n"
                        + "User: " + itemsData[1]["userId"] + " - score: " + itemsData[1]["count"];
                        
        
        outputArea.text = coinText;
        Debug.Log(coinText);
    }
}