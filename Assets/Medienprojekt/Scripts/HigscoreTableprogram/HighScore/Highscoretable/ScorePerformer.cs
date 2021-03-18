using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScorePerformer : MonoBehaviour
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
        text.text = PlayerPrefs.GetString("Performer1")+"\n"+
                    PlayerPrefs.GetString("Performer2")+"\n"+
                    PlayerPrefs.GetString("Performer3")+"\n"+
                    PlayerPrefs.GetString("Performer4")+"\n"+
                    PlayerPrefs.GetString("Performer5")+"\n"+
                    PlayerPrefs.GetString("Performer6")+"\n"+
                    PlayerPrefs.GetString("Performer7")+"\n"+
                    PlayerPrefs.GetString("Performer8")+"\n"+
                    PlayerPrefs.GetString("Performer9")+"\n"+
                    PlayerPrefs.GetString("Performer10")+"\n";
                    
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
                        string oldhighscore = "Performer" + j.ToString();
                        string newhighscore = "Performer" + (j - 1).ToString();
                        if (j == i)
                        {
                            PlayerPrefs.SetString(oldhighscore, PlayerPrefs.GetString("Performer"));
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
