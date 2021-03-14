using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetCameraPerformer : MonoBehaviour
{
    private WebCamTexture web;
    
    
    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length > 1)
        {
            web = new WebCamTexture(devices[1].name);
            GetComponent<Renderer>().material.mainTexture = web;
            web.Play();
        }
        else
        {
            web = new WebCamTexture(devices[0].name);
            GetComponent<Renderer>().material.mainTexture = web;
            web.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stop()
    {
        web.Stop();
        SceneManager.LoadScene("MainMenu"); 
    }


}
