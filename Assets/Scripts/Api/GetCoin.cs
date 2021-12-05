using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCoin : MonoBehaviour
{
    public Text Textfield;

    public void SetText() {
        string jsonResponse = ApiHelper.getApiData("http://localhost:3000/coins/1");
        //string data = getTitle(jsonResponse);
        int data = getCoin(jsonResponse);
        Textfield.text = "All coin: " + data;
    }

    // public static string getTitle(string jsonData) {
    //     Post postObj = JsonUtility.FromJson<Post>(jsonData);
    //     return postObj.title;
    // }

    public static int getCoin(string jsonData) {
        Coin coinObj = JsonUtility.FromJson<Coin>(jsonData);
        return coinObj.count;
    }
}
