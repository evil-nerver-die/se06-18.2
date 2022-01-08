using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.Networking;
using System;
using System.IO;
using System.Text;

public class PostCoin : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(PostRequest()); 
        Debug.Log(10000);
    }
    public void PostR() => StartCoroutine(PostRequest());
    public IEnumerator PostRequest()
    {
        string url = "https://locrian-humorous-crow.glitch.me/coins";
        Coin coin = new Coin();
        int currencyCoin = (int)GGPlayerSettings.instance.walletManager.CurrencyCount(CurrencyType.coins);
        coin.count = currencyCoin;
        coin.userId = 10;
        string coinToJson = JsonUtility.ToJson(coin);
        using( UnityWebRequest www = UnityWebRequest.Post(url,coinToJson))
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
                Debug.Log("Upload coin complete!");
            }
        }

    }
}     

