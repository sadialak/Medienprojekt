using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



/**
 * Regulierung der Punktzahl im Spiel. Wird beim GameObject "Score" aufgerufen.
 */
public class Score : MonoBehaviour
{

   public int score;
   private TextMeshPro text;
   
   
    // Start is called before the first frame update
    /**
     * Initialisiert die Verbindung mit Textmeshpro. Festgelegte Punktzahl wird über Unity geregelt
     */
    void Start()
    {
       
        text = this.GetComponent<TextMeshPro>();
    }

    /**
     * Erhöht die Punktzahl um die gewisse anzahl im Übergabeparameter hoch
     */
    public void IncreaseScore(int zahl)
    {
        score = score + zahl;
		if(score<0){
			score=0;
		}
    }

	public int GetScore(){
	return score;
	}

    // Update is called once per frame
    /**
     * Schreibt jedes Mal auf, wie viel Punkte der Spieler zurzeit hat
     */
    void Update()
    {
       
        text.text = "Score:" + score;
    }
}
