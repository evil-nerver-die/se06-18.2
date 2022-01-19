using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.Networking;
using System;
using System.IO;
using System.Text;

public class PutData : MonoBehaviour
{
    public void Start()
    {
        //putCoin(); 
        //putStar();
    }

    public void putCoin() => StartCoroutine(putRequestCoin());
    public void putStar() => StartCoroutine(putRequestStar());

    public IEnumerator putRequestStar()
    {
        Star star = new Star();
        star.id = 1;
        star.count = (int)GGPlayerSettings.instance.walletManager.CurrencyCount(CurrencyType.diamonds);
        star.userId = 1;
        string url = "https://lmh-json-api.herokuapp.com/stars";
        string urlparm = string.Format("{0}/{1}",url,star.id);
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

        Coin coin = new Coin();
        coin.id = 1;
        coin.count = (int)GGPlayerSettings.instance.walletManager.CurrencyCount(CurrencyType.coins);
        coin.userId = 1;

        string url = "https://lmh-json-api.herokuapp.com/coins";
        string urlparm = string.Format("{0}/{1}",url,coin.id);
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

