using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetData : MonoBehaviour
{
    // void Start() {
    //     string jsonResponse = ApiHelper.getApiData("http://localhost:3000/stars/1");
    //     int data = getStar(jsonResponse);
    //     Debug.Log("All coin: " + data);
    // }

    public static int getStar(string jsonData) {
        Star starObj = JsonUtility.FromJson<Star>(jsonData);
        return starObj.count;
    }

    public static int getCoin(string jsonData) {
        Coin coinObj = JsonUtility.FromJson<Coin>(jsonData);
        return coinObj.count;
    }
}
