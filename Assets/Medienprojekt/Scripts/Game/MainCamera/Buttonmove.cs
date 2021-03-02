using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/**
 * Wird von den Maincameras bei den Hauptspielen aufgerufen.
 * Hierbei wird in erster Linie das Instanziieren bzw. das Spawnen der
 * Buttons reguliert.
 */
public class Buttonmove : MonoBehaviour
{
    public GameObject xButton, yButton, aButton, bButton;
    public float respawnTime;
    private int zahl;
	private GameObject life;
    private GameObject score;
 
    // Start is called before the first frame update
    /**
     * hierbei werden die GameObjecte aufgerufen sowie die Funktionsaufruf zum Spawnloop gestartet
     */
    void Start()
    {
        score = GameObject.Find("Score");
		life=GameObject.Find("Life");
        StartCoroutine(SpawnButton());
    }
    
    
    void Update()
    {
        
    }


    /**
     * Der eigentliche Spawnloop des Spiels, in der bei einem gewissen Zeitloop (respawnTime)
     * die Buttons erscheinen. dabei wird random eine Zahl gezogen und je nach zahl wird der
     * Button A,B,X,Y auf den Bildschirm aufgebaut (im respawntime rhythmus)
     */
    IEnumerator SpawnButton()
    {
        
        while (true)
        {
            zahl = Random.Range(1,5);
            if (zahl == 1)
            {
                GameObject a = Instantiate(aButton) as GameObject;

            }
            if (zahl == 2)
            {
                GameObject b = Instantiate(bButton) as GameObject;
                
            }
            if (zahl == 3)
            {
                GameObject x = Instantiate(xButton) as GameObject;
                
            }
            if (zahl == 4)
            {
                GameObject y = Instantiate(yButton) as GameObject;
                
            }
            yield return new WaitForSeconds(respawnTime);
        }
       
    }
  
    
    
}
