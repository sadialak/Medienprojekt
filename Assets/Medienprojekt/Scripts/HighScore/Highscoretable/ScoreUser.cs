using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreUser : MonoBehaviour
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
        text.text = "1." + PlayerPrefs.GetString("User2") + "\n\n" +
                    "2." + PlayerPrefs.GetString("User3") + "\n\n" +
                    "3." + PlayerPrefs.GetString("User4") + "\n\n";

    }

    void PlaceCheck()
    {
        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore1"))
        {
            PlayerPrefs.SetString("User4", PlayerPrefs.GetString("User3"));
            PlayerPrefs.SetString("User3", PlayerPrefs.GetString("User2"));
            PlayerPrefs.SetString("User2", PlayerPrefs.GetString("User1"));
            PlayerPrefs.SetString("User1", PlayerPrefs.GetString("User"));
        }
        else if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore2"))
        {
            PlayerPrefs.SetString("User4", PlayerPrefs.GetString("User3"));
            PlayerPrefs.SetString("User3", PlayerPrefs.GetString("User2"));
            PlayerPrefs.SetString("User2", PlayerPrefs.GetString("User"));
        }
        else if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore3"))
        {
            PlayerPrefs.SetString("User4", PlayerPrefs.GetString("User3"));
            PlayerPrefs.SetString("User3", PlayerPrefs.GetString("User"));
        }
        else if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore4"))
        {
            PlayerPrefs.SetString("User4", PlayerPrefs.GetString("User"));
        }
    }
    
    
    
}
