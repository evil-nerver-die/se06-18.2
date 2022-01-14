using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.Networking;
using System;
using System.IO;
using System.Text;

public class PostData : MonoBehaviour
{
    public void Start()
    {
        // StartCoroutine(PostStar()); 
        // StartCoroutine(PostCoin()); 
    }
    public void postCoin() => StartCoroutine(postRequestCoin());
    public void postStar() => StartCoroutine(postRequestStar());
    public IEnumerator postRequestStar()
    {
        string url = "https://locrian-humorous-crow.glitch.me/stars";
        Star star = new Star();
       
        star.count = (int)GGPlayerSettings.instance.walletManager.CurrencyCount(CurrencyType.diamonds);
        star.userId = 10;
        string starToJson = JsonUtility.ToJson(star);
        using( UnityWebRequest www = UnityWebRequest.Post(url,starToJson))
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
                Debug.Log("Upload star complete!");
            }
        }

    }
    public IEnumerator postRequestCoin()
    {
        string url = "https://locrian-humorous-crow.glitch.me/coins";
        Coin coin = new Coin();
        coin.count = (int)GGPlayerSettings.instance.walletManager.CurrencyCount(CurrencyType.coins);
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

