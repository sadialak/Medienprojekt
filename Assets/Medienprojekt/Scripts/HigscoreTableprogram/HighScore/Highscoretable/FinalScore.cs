using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FinalScore : MonoBehaviour
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
        text.text =  PlayerPrefs.GetInt("Highscore1").ToString()+"\n"+
                     PlayerPrefs.GetInt("Highscore2")+"\n"+
                     PlayerPrefs.GetInt("Highscore3")+"\n"+
                     PlayerPrefs.GetInt("Highscore4")+"\n"+
                     PlayerPrefs.GetInt("Highscore5")+"\n"+
                     PlayerPrefs.GetInt("Highscore6")+"\n"+
                     PlayerPrefs.GetInt("Highscore7")+"\n"+
                     PlayerPrefs.GetInt("Highscore8")+"\n"+
                     PlayerPrefs.GetInt("Highscore9")+"\n"+
                     PlayerPrefs.GetInt("Highscore10")+"\n";
                    
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
                        string oldhighscore = "Highscore" + j.ToString();
                        string newhighscore = "Highscore" + (j - 1).ToString();
                        if (j == i)
                        {
                            PlayerPrefs.SetInt(oldhighscore, PlayerPrefs.GetInt("Score"));
                        }
                        else
                        {
                            PlayerPrefs.SetInt(oldhighscore, PlayerPrefs.GetInt(newhighscore));

                        }

                    }

                    break;
                }
            }

            PlayerPrefs.SetInt("Score", -1);
        }
    }
}
