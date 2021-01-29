using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
    private WebCamTexture web;
    private PlayerControls controls;
    // Start is called before the first frame update
    void Awake()
    {
		web = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = web;
        web.Play();
        controls = new PlayerControls();
        controls.Gameplay.Start.performed += ctx => NextScene();
        controls.Gameplay.Select.performed += ctx => Application.Quit();
    }

    void NextScene()
    {
		web.Stop();
        SceneManager.LoadScene("CountDown");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnEnable(){
        controls.Gameplay.Enable();
    }

    void OnDisable(){
        controls.Gameplay.Disable();
    }
}
