using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TodayYouPlaywith : MonoBehaviour
{
    private TextMeshPro text;
    float currentTime = 0f;
    public float startingTime;
    private GameObject timer;
    
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<TextMeshPro>();
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        text.text =PlayerPrefs.GetString("Performer");
        
        currentTime -= 1 * Time.deltaTime;
        

        if (currentTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
