using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.Networking;
using System;
using System.IO;
using System.Text;

public class DeleteData : MonoBehaviour
{
    public void Start()
    {
        // StartCoroutine(deleteStar()); 
        // StartCoroutine(deleteCoin()); 
        // for ( int i = 2; i<=19;i++) {
        //     StartCoroutine(deleteStar(i)); 
        // }
    }
    public IEnumerator deleteStar(int id)
    {

        string url = "https://lmh-json-api.herokuapp.com/stars";
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
                Debug.Log("Delete data star complete");
            }
        }

    }
    
    public IEnumerator deleteCoin(int id)
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
                Debug.Log("Delete data coin complete");
            }
        }

    }
}        

