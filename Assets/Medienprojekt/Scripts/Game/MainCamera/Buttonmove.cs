using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Buttonmove : MonoBehaviour
{
    public GameObject xButton, yButton, aButton, bButton;
    public float respawnTime = 3.0f;
    private int zahl;
	private GameObject life;
    private GameObject score;
 
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score");
		life=GameObject.Find("Life");
        StartCoroutine(SpawnButton());
    }
    
    
    void Update()
    {
        if (score.GetComponent<Score>().GetScore() >= 500)
        {
            respawnTime = 1.2f;
        }


    }

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
