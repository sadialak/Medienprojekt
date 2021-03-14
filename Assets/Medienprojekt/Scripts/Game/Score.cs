using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



/**
 * Regulierung der Punktzahl im Spiel. Wird beim GameObject "Score" aufgerufen.
 */
public class Score : MonoBehaviour
{
    public int level;
   private int score;
   private TextMeshPro text;
   
   
    // Start is called before the first frame update
    /**
     * Initialisiert die Verbindung mit Textmeshpro. Festgelegte Punktzahl wird über Unity geregelt
     */
    void Start()
    {
       
        text = this.GetComponent<TextMeshPro>();
        if (level == 1)
        {
            PlayerPrefs.SetInt("Score", 0);
        }

    }

    /**
     * Erhöht die Punktzahl um die gewisse anzahl im Übergabeparameter hoch
     */
    public void IncreaseScore(int zahl)
    {
        score = PlayerPrefs.GetInt("Score",0) + zahl;
        PlayerPrefs.SetInt("Score", score);
    }

    public int GetLevel()
    {
        return level;
    }
	public int GetScore()
    {
        return PlayerPrefs.GetInt("Score", 0);
    }

    // Update is called once per frame
    /**
     * Schreibt jedes Mal auf, wie viel Punkte der Spieler zurzeit hat
     */
    void Update()
    {
        text.text = "Score:" + PlayerPrefs.GetInt("Score",0);
    }
}
