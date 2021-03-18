using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreUser : MonoBehaviour
{
    
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
        PlaceCheck();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "1." + PlayerPrefs.GetString("User1") + "\n" +
                    "2." + PlayerPrefs.GetString("User2") + "\n" +
                    "3." + PlayerPrefs.GetString("User3") + "\n" +
                    "4." + PlayerPrefs.GetString("User4") + "\n" +
                    "5." + PlayerPrefs.GetString("User5") + "\n" +
                    "6." + PlayerPrefs.GetString("User6") + "\n" +
                    "7." + PlayerPrefs.GetString("User7") + "\n" +
                    "8." + PlayerPrefs.GetString("User8") + "\n" +
                    "9." + PlayerPrefs.GetString("User9") + "\n" +
                    "10." + PlayerPrefs.GetString("User10") + "\n" ;

    }

    void PlaceCheck()
    {

        if (PlayerPrefs.GetInt("Score") >= 0)
        {
            for (int i = 1; i <= 11; i++)
            {
                string highscore = "Highscore" + i.ToString();
                if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt(highscore))
                {
                    for (int j = 11; j >= i; j--)
                    {
                        string oldhighscore = "User" + j.ToString();
                        string newhighscore = "User" + (j - 1).ToString();
                        if (j == i)
                        {
                            PlayerPrefs.SetString(oldhighscore, PlayerPrefs.GetString("User"));
                        }
                        else
                        {
                            PlayerPrefs.SetString(oldhighscore, PlayerPrefs.GetString(newhighscore));

                        }

                    }

                    break;
                }
            }
        }
    }
    
    
    
}
