using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetCamera : MonoBehaviour
{
    private WebCamTexture web;
	private GameObject life;
    
  
    
    // Start is called before the first frame update
    void Start()
    {
		
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
