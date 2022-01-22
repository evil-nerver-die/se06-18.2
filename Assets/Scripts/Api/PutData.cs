using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.Networking;
using System;
using System.IO;
using System.Text;
using SimpleJSON;

public class PutData : MonoBehaviour
{

    public static string urlCoin = "https://lmh-json-api.herokuapp.com/coins";
    public static string urlStar = "https://lmh-json-api.herokuapp.com/stars";
    public static string urlUser = "https://lmh-json-api.herokuapp.com/users";
    public static string jsonResponseUser = ApiHelper.getApiData(urlUser);
    public static JSONNode itemsDataUser = JSON.Parse(jsonResponseUser);
    public int userId = 0;
    public int id = 0;
    public bool valid = true;

    public void Start()
    {
        // putCoin(); 
        // putStar();
    }
    
    public void putCoin() => StartCoroutine(putRequestCoin());
    public void putStar() => StartCoroutine(putRequestStar());

    public IEnumerator putRequestStar()
    {
        foreach (JSONNode nodeUser in itemsDataUser.AsArray) {
            string content = (string)nodeUser["name"];
            if(ReadText.getUsername().Trim() == content.Trim()) {
               userId = nodeUser["id"];
            }
            else {
                int c = itemsDataUser.AsArray.Count;
                id = itemsDataUser.AsArray[c-1]["id"] + 1;
            }
        }
        if(userId == 0) {
            userId = id;
        }
        Star star = new Star();
        star.id = userId;
        star.count = (int)GGPlayerSettings.instance.walletManager.CurrencyCount(CurrencyType.diamonds);
        star.userId = userId;
        string urlparm = string.Format("{0}/{1}",urlStar,star.id);
        string starToJson = JsonUtility.ToJson(star);
        using( UnityWebRequest www = UnityWebRequest.Put(urlparm,starToJson))
        {
            www.SetRequestHeader("content-type", "application/json");
            www.uploadHandler.contentType = "application/json";
            www.uploadHandler = new UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(starToJson));
            
            yield return www.SendWebRequest();
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Update star complete!");
            }
        }

    }
    public IEnumerator putRequestCoin()
    {
        foreach (JSONNode nodeUser in itemsDataUser.AsArray) {
            string content = (string)nodeUser["name"];
            if(ReadText.getUsername().Trim() == content.Trim()) {
               userId = nodeUser["id"];
            }
            else {
                int c = itemsDataUser.AsArray.Count;
                id = itemsDataUser.AsArray[c-1]["id"] + 1;
            }
        }
        if(userId == 0) {
            userId = id;
        }
        Coin coin = new Coin();
        coin.id = userId;
        coin.count = (int)GGPlayerSettings.instance.walletManager.CurrencyCount(CurrencyType.coins);
        coin.userId = userId;

        string urlparm = string.Format("{0}/{1}",urlCoin,coin.id);
        string coinToJson = JsonUtility.ToJson(coin);
        using( UnityWebRequest www = UnityWebRequest.Put(urlparm,coinToJson))
        {
            www.SetRequestHeader("content-type", "application/json");
            www.uploadHandler.contentType = "application/json";
            www.uploadHandler = new UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(coinToJson));
            
            yield return www.SendWebRequest();
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Update coin complete!");
            }
        }

    }
}        

