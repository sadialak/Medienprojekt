using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScorePerformer : MonoBehaviour
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
        text.text = PlayerPrefs.GetString("Performer1")+"\n\n"+
                    PlayerPrefs.GetString("Performer2")+"\n\n"+
                    PlayerPrefs.GetString("Performer3")+"\n\n";
                    
    }

    void PlaceCheck()
    {
        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore1"))
        {
            PlayerPrefs.SetString("Performer4", PlayerPrefs.GetString("Performer3"));
            PlayerPrefs.SetString("Performer3", PlayerPrefs.GetString("Performer2"));
            PlayerPrefs.SetString("Performer2", PlayerPrefs.GetString("Performer1"));
            PlayerPrefs.SetString("Performer1", PlayerPrefs.GetString("Performer"));
        }
        else if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore2"))
        {
            PlayerPrefs.SetString("Performer4", PlayerPrefs.GetString("Performer3"));
            PlayerPrefs.SetString("Performer3", PlayerPrefs.GetString("Performer2"));
            PlayerPrefs.SetString("Performer2", PlayerPrefs.GetString("Performer"));
        }
        else if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore3"))
        {
            PlayerPrefs.SetString("Performer4", PlayerPrefs.GetString("Performer3"));
            PlayerPrefs.SetString("Performer3", PlayerPrefs.GetString("Performer"));
        }
        else if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore4"))
        {
            PlayerPrefs.SetString("Performer4", PlayerPrefs.GetString("Performer"));
        }
    }
}
