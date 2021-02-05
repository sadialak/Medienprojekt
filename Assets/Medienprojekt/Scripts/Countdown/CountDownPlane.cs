using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * Webcamhintergrund von Level 1 des Spiels. wird vor dem Hauptspiel
 * von Level 1 aufgerufen. dabei nutzt es den Timer, um von da
 * aus bestimmen zu können, wann es zum Hauptspiel übergehen kann
 * 
 */

public class CountDownPlane : MonoBehaviour
{
    private WebCamTexture web;
    private GameObject timer;
    // Start is called before the first frame update
    
    /**
     * nutzt die Startfunktion, um Webcam zu initialisieren als auch um diese zu starten.
     * Greift auf das Objekt "Canvas zu,um auf den Timer zu greifen.
     */
    void Start()
    {
        web = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = web;
        web.Play();
        timer=GameObject.Find("Canvas");
    }

    // Update is called once per frame
    /**
     * Wartet bis der Countdown des Timers auf 0 geht und geht dann
     *  in die Funktion "SetNextScene" um zum Hauptspiel zu wechseln
     */
    void Update()
    {
        if (timer.GetComponent<CountdownTimer>().GetCurrentTime() == 0)
        {
            StartCoroutine(SetNextScene());
            
        }
    }
    
    /**
     * Wechseln in das Haupspiel. Dabei wird vorher die Webcam gestoppt,
     * da sie ansonsten später abbrechen würde :P
     */
    IEnumerator SetNextScene(){
    
        yield return new WaitForSeconds(0);
        web.Stop();
        SceneManager.LoadScene("Game");
        
    }
}
