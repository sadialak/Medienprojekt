using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetCamera : MonoBehaviour
{
    private WebCamTexture web;

  
    
    // Start is called before the first frame update
    void Start()
    {
        web = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = web;
        web.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
