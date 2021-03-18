using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HighscoreCamera : MonoBehaviour
{

    
    
    /**
     * Bei der Awake function wird die Webcam intiliasiert und aufgerufen als auch der Controller
     * und deren Input.
     * Input: sollte "Start" gedrückt werden, soll die Kamera gestoppt werden und zum Hauptmenü
     * zurückkehren (Szenenwechsel zum Hauptmenü)
     */
    void Start()
    {

    }

    
    /**
     * wird beim Start Input aufgerufen. Dabei soll die webcam gestoppt (da sonst abbruch)
     * und dann zum Hauptmenü als Szene zurückkehren zurückkehren
     */

    
    public void Performer()
    {
        SceneManager.LoadScene("PerformerKeyboard");
    }
    
    public void Reset()
    {
        
        PlayerPrefs.DeleteAll();
    }
    
    public void Eintragen()
    {
        SceneManager.LoadScene("HighscoreKeyboard");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
   
}
