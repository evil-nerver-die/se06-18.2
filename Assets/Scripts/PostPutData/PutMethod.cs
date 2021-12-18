using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.Networking;
using System;
using System.IO;
using System.Text;

public class PutMethod : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(PutCoin()); 
    }
    public IEnumerator PutStar()
    {
        Star star = new Star();
        star.id = 4;
        star.count = 55;
        star.userId = 4;
        string url = "https://locrian-humorous-crow.glitch.me/stars/4";
        string starToJson = JsonUtility.ToJson(star);
        using( UnityWebRequest www = UnityWebRequest.Put(url,starToJson))
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
                Debug.Log("Update complete!");
            }
        }

    }
    public IEnumerator PutCoin()
    {

        Coin coin = new Coin();
        coin.id = 5;
        coin.count = 25;
        coin.userId = 5;

        string url = "https://locrian-humorous-crow.glitch.me/coins/5";
        string coinToJson = JsonUtility.ToJson(coin);
        using( UnityWebRequest www = UnityWebRequest.Put(url,coinToJson))
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
                Debug.Log("Update complete!");
            }
        }

    }
}        

