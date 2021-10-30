using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.IO;

public class GetPost : MonoBehaviour
{
    public Text Textfield;

    public void SetText() {
        string data = getPost();
        Textfield.text = data;
    }

    public static string getPost() {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://jsonplaceholder.typicode.com/posts/1");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        return jsonResponse;
    }
}
