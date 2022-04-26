using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kietaddress : MonoBehaviour
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
        Application.OpenURL("https://www.google.co.in/maps/place/KIET+Group+of+Institutions/@28.7531964,77.4950753,17z/data=!3m1!4b1!4m5!3m4!1s0x390cf574d18f2b6f:0x4a65c0bc0122eb2f!8m2!3d28.7531917!4d77.497264?hl=en&authuser=0");
    }
}
