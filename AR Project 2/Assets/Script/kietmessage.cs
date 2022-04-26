using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kietmessage : MonoBehaviour
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
        Application.OpenURL("sms:" + 8802140619);
    }
}
