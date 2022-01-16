using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
// using SimpleJSON;
// using Newtonsoft.Json;


public class GetMethod : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetData();
    }

    void GetData() => StartCoroutine(GetData_Coroutine());

    IEnumerator GetData_Coroutine()
    {
        string url = "https://locrian-humorous-crow.glitch.me/coins/1";
        using(UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();
            // Coin[] c = JsonConvert.DeserializeObject<Coin[]>(request.downloadHandler.text);
            Coin c = JsonUtility.FromJson<Coin>(request.downloadHandler.text);
            if(request.isNetworkError || request.isHttpError)
                Debug.Log(request.error);
            else
                
                    Debug.Log(c.count);
                
        }
    }
}