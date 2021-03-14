using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TodayYouPlaywith : MonoBehaviour
{
    private TextMeshPro text;
    
    
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<TextMeshPro>();
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text ="Today you play with: "+PlayerPrefs.GetString("Performer");
        
    }
}
