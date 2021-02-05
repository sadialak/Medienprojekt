using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * Wird bei der Plane (beim Webcamhintergrund) aufgerufen. hierbei wird
 * der Aufruf des GameOvers geregelt und wie es von da aus weitergeht
 */
public class GameOver : MonoBehaviour
{
	private WebCamTexture web;
    private PlayerControls controls;
    
    
    
    /**
     * Bei der Awake function wird die Webcam intiliasiert und aufgerufen als auch der Controller
     * und deren Input.
     * Input: sollte "Start" gedrückt werden, soll die Kamera gestoppt werden und zum Hauptmenü
     * zurückkehren (Szenenwechsel zum Hauptmenü)
     */
    void Awake()
    {
		
        web = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = web;
        web.Play();
        controls = new PlayerControls();
        controls.Gameplay.Start.performed += ctx => NextScene();
    }

    
    /**
     * wird beim Start Input aufgerufen. Dabei soll die webcam gestoppt (da sonst abbruch)
     * und dann zum Hauptmenü als Szene zurückkehren zurückkehren
     */
    void NextScene()
    {
		web.Stop();
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /**
     *  Funktion OnEnable und OnDisable sind notwendig, damit die Controllereingaben
     *  erst richtig erkannt werden.
     */
    
    void OnEnable(){
        controls.Gameplay.Enable();
    }

    void OnDisable(){
        controls.Gameplay.Disable();
    }

}
