using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.Networking;
using System;
using System.IO;
using System.Text;

public class DeleteMethod : MonoBehaviour
{
    //public string url = "https://locrian-humorous-crow.glitch.me/coins";
    // public void Start()
    // {
    //     // for(int i=4099; i<= 4584;i++){
    //     //     StartCoroutine(DeleteCoin(i)); 
    //     // }
    //     //StartCoroutine(DeleteCoin(4565));
    // }
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
    public IEnumerator DeleteCoin(int id)
    {
        string url = "https://locrian-humorous-crow.glitch.me/coins";
        string urlparm = string.Format("{0}/{1}",url,id);
        using( UnityWebRequest www = UnityWebRequest.Delete(urlparm))
        {
            yield return www.SendWebRequest();
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(id);
            }
        }

    }
}        

