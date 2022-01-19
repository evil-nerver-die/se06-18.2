using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;


public class GetData : MonoBehaviour
{
    void Start() {
        string jsonResponse = ApiHelper.getApiData("https://lmh-json-api.herokuapp.com/coins");
        JSONNode itemsData = JSON.Parse(jsonResponse);
        Debug.Log(itemsData[0]);
        string coinText = "User: " + itemsData[0]["userId"] + " - score: " + itemsData[0]["count"] + "\n"
                        + "User: " + itemsData[1]["userId"] + " - score: " + itemsData[1]["count"];
        Debug.Log(coinText);
    }

    public static int getStar(string jsonData) {
        Star starObj = JsonUtility.FromJson<Star>(jsonData);
        return starObj.count;
    }

    public static int getCoin(string jsonData) {
        Coin coinObj = JsonUtility.FromJson<Coin>(jsonData);
        return coinObj.count;
    }
}
