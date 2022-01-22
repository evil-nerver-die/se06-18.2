using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
using TMPro;

public class GetMethod : MonoBehaviour
{
    public static string urlUser = "https://lmh-json-api.herokuapp.com/users";
    public static string jsonResponseUser = ApiHelper.getApiData(urlUser);
    public static JSONNode itemsDataUser = JSON.Parse(jsonResponseUser);
    public int userId = 0;
    public int id = 0;
    public bool valid = true;
    TextMeshProUGUI outputArea;
    // Start is called before the first frame update
    void Start()
    {
        outputArea = GameObject.Find("Output").GetComponent<TextMeshProUGUI>();
        StartCoroutine(getData());
    }

    public IEnumerator getData() {
        yield return new WaitForSeconds(1);
        string jsonResponse = ApiHelper.getApiData("https://lmh-json-api.herokuapp.com/coins");
        JSONNode itemsData = JSON.Parse(jsonResponse);
        int count = itemsData.AsArray.Count;
        string coinText = "";
        for (int i=0; i< count-1;i++) {
            for (int j=i+1; j< count ; j++) {
                if(itemsData[i]["count"] < itemsData[j]["count"]) {
                    JSONNode t = itemsData[i];
                    itemsData[i] = itemsData[j];
                    itemsData[j] = t;
                }
            }
        }
        int index = 0;
        if (count < 8) {
            index = count;
        }else {
            index = 8;
        }
        if(count >  itemsDataUser.AsArray.Count) {
            itemsDataUser[count-1]["id"] = count;
            itemsDataUser[count-1]["name"] = ReadText.getUsername();
        }
        for (int i = 0; i < index;i++) {
            foreach (JSONNode layerNode in itemsDataUser.AsArray) {
                if(itemsData[i]["userId"] == layerNode["id"]) {
                    coinText += "Name : " + layerNode["name"] + "  -  score : " + itemsData[i]["count"] + "\n";
                }
            }  
        }
        outputArea.text = coinText;
        Debug.Log(coinText);
    }
}