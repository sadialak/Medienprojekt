using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetCamera2 : MonoBehaviour
{
    private WebCamTexture web;
    private GameObject score;
    private GameObject life;
    
  
    
    // Start is called before the first frame update
    void Start()
    {
        score=GameObject.Find("Score");
        life=GameObject.Find("Life");
        web = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = web;
        web.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(life.GetComponent<Life>().GetLife()<1){
            web.Stop();
            SceneManager.LoadScene("GameOver");
        }
    }
}
