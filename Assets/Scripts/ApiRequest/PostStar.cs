using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.Networking;
using System;
using System.IO;
using System.Text;
public class PostStar : MonoBehaviour
{
    public void Start()
    {
        PostR();
    }
    public void PostR() => StartCoroutine(PostRequest());
    public IEnumerator PostRequest()
    {
        string url = "https://locrian-humorous-crow.glitch.me/stars";
        Star star = new Star();
        int currencyStar = (int)GGPlayerSettings.instance.walletManager.CurrencyCount(CurrencyType.diamonds);
        star.count = currencyStar;
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
}     

