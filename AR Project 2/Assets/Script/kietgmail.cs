using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kietgmail : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       private void OnMouseDown()
    {
         string email = "director@kiet.edu";
         string subject = MyEscapeURL("Appeal");
         string body = MyEscapeURL("My Cover\r\n Dear Sir, Change the name of KIET Ghaziabad from IIT Ghaziabad");
         Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
     }
        string MyEscapeURL(string url)
        {
            return WWW.EscapeURL(url).Replace("+", "%20");
        }
}
