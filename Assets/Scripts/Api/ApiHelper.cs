using System.Net;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApiHelper 
{
    public static string getApiData(string url) {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        return jsonResponse;
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