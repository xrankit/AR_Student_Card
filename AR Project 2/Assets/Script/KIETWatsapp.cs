using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KIETWatsapp : MonoBehaviour
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
        Application.OpenURL("https://api.whatsapp.com/send?phone=918588811998&app=facebook&entry_point=page_cta&fbclid=IwAR0W4u6fbMOsCQJXNW0RaiahOZ6S1RMXxl9cxtFrLcZgGLH13A4OEInNooQ");
    }
    
}
