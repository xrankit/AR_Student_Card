using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kietphone : MonoBehaviour
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
        Application.OpenURL("tel:\\18003130056");
    }
}
