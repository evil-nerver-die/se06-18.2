using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.Networking;
using System;
using System.IO;
using System.Text;

public class PostMethod : MonoBehaviour
{
    // public void Start()
    // {
    //     StartCoroutine(PostCoin()); 
    // }
    public IEnumerator PostStar()
    {
        string url = "https://locrian-humorous-crow.glitch.me/stars";
        Star star = new Star();
        star.count = 78;
        star.userId = 4;
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
                Debug.Log("Upload complete!");
            }
        }

    }
    public IEnumerator PostCoin()
    {
        string url = "https://locrian-humorous-crow.glitch.me/coins";
        Coin coin = new Coin();
        coin.count = 10;
        coin.userId = 7;
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
                Debug.Log("Upload complete!");
            }
        }

    }
}        

