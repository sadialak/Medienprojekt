using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FinalScore : MonoBehaviour
{
    private TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<TextMeshPro>();
        PlaceCheck();
    }

    // Update is called once per frame
    void Update()
    {
        text.text =  PlayerPrefs.GetInt("Highscore1").ToString()+"\n\n"+
                     PlayerPrefs.GetInt("Highscore2")+"\n\n"+
                     PlayerPrefs.GetInt("Highscore3")+"\n\n";
                    
    }

    void PlaceCheck()
    {
        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore1"))
        {
            PlayerPrefs.SetInt("Highscore4", PlayerPrefs.GetInt("Highscore3"));
            PlayerPrefs.SetInt("Highscore3", PlayerPrefs.GetInt("Highscore2"));
            PlayerPrefs.SetInt("Highscore2", PlayerPrefs.GetInt("Highscore1"));
            PlayerPrefs.SetInt("Highscore1", PlayerPrefs.GetInt("Score"));
        }
        else if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore2"))
        {
            PlayerPrefs.SetInt("Highscore4", PlayerPrefs.GetInt("Highscore3"));
            PlayerPrefs.SetInt("Highscore3", PlayerPrefs.GetInt("Highscore2"));
            PlayerPrefs.SetInt("Highscore2", PlayerPrefs.GetInt("Score"));
        }
        else if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore3"))
        {
            PlayerPrefs.SetInt("Highscore4", PlayerPrefs.GetInt("Highscore3"));
            PlayerPrefs.SetInt("Highscore3", PlayerPrefs.GetInt("Score"));
        }
        else if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore4"))
        {
            PlayerPrefs.SetInt("Highscore4", PlayerPrefs.GetInt("Score"));
        }
    }
}
