using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour // I forgot the u in MonoBehaviour the first time and the application did not like it.
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("Hello Again");
    }

    // Update is called once per frame and continues until we tell it to stop.
    void Update()
    {
        Debug.Log("And Again...");
    }
    
}
