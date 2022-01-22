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
public class PostData : MonoBehaviour
{
    public static string urlCoin = "https://lmh-json-api.herokuapp.com/coins";
    public static string urlStar = "https://lmh-json-api.herokuapp.com/stars";
    public static string jsonResponseStar = ApiHelper.getApiData(urlStar);
    public static JSONNode itemsDataStar = JSON.Parse(jsonResponseStar);
    public static string jsonResponseCoin = ApiHelper.getApiData(urlCoin);
    public static JSONNode itemsDataCoin = JSON.Parse(jsonResponseCoin);
    public int userId = 0;
    public bool valid = true;

    public void Start() {
        postUser();
    }
    
    public void postCoin() => StartCoroutine(postRequestCoin());
    public void postStar() => StartCoroutine(postRequestStar());
    public void postUser() => StartCoroutine(postRequestUser());

    public IEnumerator postRequestStar()
    {
        string urlUser = "https://lmh-json-api.herokuapp.com/users";
        string jsonResponseUser = ApiHelper.getApiData(urlUser);
        JSONNode itemsDataUser = JSON.Parse(jsonResponseUser);
        foreach (JSONNode nodeUser in itemsDataUser.AsArray) {
            string content = (string)nodeUser["name"];
            if(ReadText.getUsername().Trim() == content.Trim()) {
               userId = nodeUser["id"];
            }
        }

        foreach (JSONNode nodeStar in itemsDataStar.AsArray) {
            if(nodeStar["id"] == userId) {
                valid = false;
            }
        }
        Star star = new Star();
        star.count = (int)GGPlayerSettings.instance.walletManager.CurrencyCount(CurrencyType.diamonds);
        star.userId = userId;
        string starToJson = JsonUtility.ToJson(star);
        if(valid) {
            using( UnityWebRequest www = UnityWebRequest.Post(urlStar,starToJson))
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
        }else {
            var tempgameObject = new GameObject();
		    PutData put = tempgameObject.AddComponent<PutData>();
            put.putStar();
        }
    }
    public IEnumerator postRequestCoin()
    {
        string urlUser = "https://lmh-json-api.herokuapp.com/users";
        string jsonResponseUser = ApiHelper.getApiData(urlUser);
        JSONNode itemsDataUser = JSON.Parse(jsonResponseUser);
        foreach (JSONNode nodeUser in itemsDataUser.AsArray) {
            string content = (string)nodeUser["name"];
            if(ReadText.getUsername().Trim() == content.Trim()) {
               userId = nodeUser["id"];
            }
        }
        foreach (JSONNode nodeCoin in itemsDataCoin.AsArray) {
            if(nodeCoin["id"] == userId) {
                valid = false;
            }
        }
        Coin coin = new Coin();
        coin.count = (int)GGPlayerSettings.instance.walletManager.CurrencyCount(CurrencyType.coins);
        coin.userId = userId;
        string coinToJson = JsonUtility.ToJson(coin);
        if(valid) {
            using( UnityWebRequest www = UnityWebRequest.Post(urlCoin,coinToJson))
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
        }else {
            var tempgameObject = new GameObject();
		    PutData put = tempgameObject.AddComponent<PutData>();
            put.putCoin();
        }

    }

    public IEnumerator postRequestUser()
    {
        string urlUser = "https://lmh-json-api.herokuapp.com/users";
        string jsonResponseUser = ApiHelper.getApiData(urlUser);
        JSONNode itemsDataUser = JSON.Parse(jsonResponseUser);
        User user = new User();
        user.name = ReadText.getUsername();
        string userToJson = JsonUtility.ToJson(user);
        bool valid = true;
        foreach (JSONNode layerNode in itemsDataUser.AsArray) {
            if(layerNode["name"] == ReadText.getUsername()) {
               valid = false;
            }
        }
        if(valid) {
            using( UnityWebRequest www = UnityWebRequest.Post(urlUser,userToJson))
            {
                www.SetRequestHeader("content-type", "application/json");
                www.uploadHandler.contentType = "application/json";
                www.uploadHandler = new UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(userToJson));
                
                yield return www.SendWebRequest();
                if (www.result != UnityWebRequest.Result.Success)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log("Upload user complete!");
                    postCoin();
                    postStar();
                }
            }
        }else {
            Debug.Log("name already exists");
            postCoin();
            postStar();
        }
    }
    
}     

