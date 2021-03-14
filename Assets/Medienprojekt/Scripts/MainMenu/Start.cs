using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * Wird bei der Plane (beim Webcamhintergrund) aufgerufen. hierbei wird
 * der Aufruf des Hauptmenüs geregelt und wie es von da aus weitergeht
 */
public class Start : MonoBehaviour
{
    private static WebCamTexture web;
    private PlayerControls controls;

    
    // Start is called before the first frame update
    
    /**
     * Bei der Awake function wird die Webcam intiliasiert und aufgerufen als auch der Controller
     * und deren Input.
     * Input: sollte "Start" gedrückt werden, soll die Kamera gestoppt werden und zum Hauptmenü
     * zurückkehren (Szenenwechsel zum Countdown)
     * sollte "Select" gedrückt werden, wird das Spiel beendet
     */
    void Awake()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
		web = new WebCamTexture(devices[1].name);
        GetComponent<Renderer>().material.mainTexture = web;
        web.Play();
        controls = new PlayerControls();
        controls.Gameplay.ASmash.performed += ctx => Performer();
        controls.Gameplay.Start.performed += ctx => NextScene();
        controls.Gameplay.Select.performed += ctx => Application.Quit();
    }

    /**
     * wird beim Start Input aufgerufen. Dabei soll die webcam gestoppt (da sonst abbruch)
     * und dann zum ersten Countdown des Spiels übergehen
     */
    void NextScene()
    {
		web.Stop();
        SceneManager.LoadScene("Game");
    }
    
    void Performer()
    {
        web.Stop();
        SceneManager.LoadScene("PerformerKeyboard");
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
