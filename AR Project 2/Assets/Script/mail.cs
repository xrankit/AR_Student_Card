using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mail : MonoBehaviour
{
    void Update()
    {
       
    }
    private void OnMouseDown()
    {
         string email = "ankiii0071@gmail.com";
         string subject = MyEscapeURL("HI");
         string body = MyEscapeURL("My Cover\r\n Hi Nice to meet you");
         Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
     }
        string MyEscapeURL(string url)
        {
            return WWW.EscapeURL(url).Replace("+", "%20");
        }
}
