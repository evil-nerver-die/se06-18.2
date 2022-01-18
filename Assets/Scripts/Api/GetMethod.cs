using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using SimpleJSON;

public class GetMethod : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        string jsonResponse = ApiHelper.getApiData("https://lmh-json-api.herokuapp.com/coins");
        JSONNode itemsData = JSON.Parse(jsonResponse);
        string coinText = "User: " + itemsData[0]["userId"] + " - score: " + itemsData[0]["count"] + "\n"
                        + "User: " + itemsData[1]["userId"] + " - score: " + itemsData[1]["count"];
        Debug.Log(coinText);
    }
}