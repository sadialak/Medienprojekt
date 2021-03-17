using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
* Wird im Plane (webcamhintergrund) von Game abgespielt. Von da aus
* wird auch der Szenenwechsel vom zweiten Teil des Hauptspiels geregelt.
*/
public class GetCamera2 : MonoBehaviour
{
    private WebCamTexture web;
    private GameObject score;
    private GameObject life;
    
  
    
    // Start is called before the first frame update
	/**
	*Hierbei wird die Webcam initialisiert und abgespielt als auch zu den
	*Gameobjecten Score und Life zugegriffen für die Funktionen.
	*/
    void Start()
    {
        score=GameObject.Find("Score");
        life=GameObject.Find("Life");
        WebCamDevice[] devices = WebCamTexture.devices;
        web = new WebCamTexture(devices[0].name);
        GetComponent<Renderer>().material.mainTexture = web;
        web.Play();

    }

    // Update is called once per frame
	/**
	* Es wird beim Objekt Score überbprüft ob gewisse Kriterien eingehalten werden .
	* sollten die Leben auf 0 fallen,
	* soll dann zur entsprechenden Szene gewechselt werden.
	*/
    void Update()
    {
        
        if(life.GetComponent<Life>().GetLife()<1){
          //  Destroy(GameObject.Find("MusicManager"));
            web.Stop();
            SceneManager.LoadScene("GameOver");
        }
    }
}
