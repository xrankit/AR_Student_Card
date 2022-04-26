using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddressLocation : MonoBehaviour
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
        Application.OpenURL("https://www.google.com/maps/place/Hashimpur,+Uttar+Pradesh+232105/@25.4494933,83.3177134,15.96z/data=!4m5!3m4!1s0x398e1e90b60fae75:0xfa6377c2b4ffe90a!8m2!3d25.447626!4d83.3241592");
    }
}
