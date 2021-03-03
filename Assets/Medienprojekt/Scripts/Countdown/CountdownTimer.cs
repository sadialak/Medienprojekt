using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;

    }



    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString ("0");

        if (currentTime <= 0)
        {
            Destroy(this.gameObject);
        }
        
    }

    
    /**
     * gibt die aktuelle Zeit wieder. Wird benötigt für CountdownPlane
     */
    public float GetCurrentTime()
    {
        return currentTime;
    }
}
