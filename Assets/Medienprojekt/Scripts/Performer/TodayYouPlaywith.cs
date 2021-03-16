using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TodayYouPlaywith : MonoBehaviour
{
    public Text text;
    
    
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text ="Today you play with: "+PlayerPrefs.GetString("Performer");
        
    }
}
