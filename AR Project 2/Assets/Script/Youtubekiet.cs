using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Youtubekiet : MonoBehaviour
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
        Application.OpenURL("https://www.youtube.com/channel/UC4rxBQyVV00oGX9-m2aqKYw");
    }
}
