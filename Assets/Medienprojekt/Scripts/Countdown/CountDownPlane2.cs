using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CountDownPlane2 : MonoBehaviour
{
    private WebCamTexture web;
    private GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        web = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = web;
        web.Play();
        timer=GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.GetComponent<CountdownTimer>().GetCurrentTime() == 0)
        {
            StartCoroutine(SetNextScene());
        }
    }
    
    IEnumerator SetNextScene(){
    
        yield return new WaitForSeconds(1);
        web.Stop();
        SceneManager.LoadScene("Game2");
	
    }
}