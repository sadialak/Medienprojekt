using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
* Wird im Plane (webcamhintergrund) von Game abgespielt. Von da aus
* wird auch der Szenenwechsel vom ersten Teil des Hauptspiels geregelt.
*/
public class GetCamera : MonoBehaviour
{
    private WebCamTexture web;
    private GameObject score;
	private GameObject life;

	private float currentTime;
  
    
    // Start is called before the first frame update
	/**
	*Hierbei wird die Webcam initialisiert und abgespielt als auch zu den
	*Gameobjecten Score und Life zugegriffen für die Funktionen.
	*/
    void Start()
    {
	    currentTime = 128f;
	    score=GameObject.Find("Score");
		life=GameObject.Find("Life");
		WebCamDevice[] devices = WebCamTexture.devices;
		web = new WebCamTexture(devices[1].name);
        GetComponent<Renderer>().material.mainTexture = web;
        web.Play();

    }
	
	public float getCurrentTime()
	{
		return currentTime;
	}

    // Update is called once per frame
	/**
	* Es wird beim Objekt Score überbprüft ob gewisse Kriterien eingehalten werden (genauso wie bei Life).
	* sollte eine eine gewisse Punktzahl erreicht werden oder die Leben auf 0 fallen,
	* soll dann zur entsprechende Szene gewechselt werden.
	*/
    void Update()
    {
	    
	    currentTime -= 1 * Time.deltaTime;
	    
	    if (currentTime<=0)
	    {
		   // Destroy(GameObject.Find("MusicManager"));
		    web.Stop();
		    SceneManager.LoadScene("Game2");
	    }

	    if(life.GetComponent<Life>().GetLife()<1){
		   // Destroy(GameObject.Find("MusicManager"));
			web.Stop();
			SceneManager.LoadScene("GameOver");
		}
    }
}
