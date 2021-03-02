using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



/**
 * Regulierung der Leben im Spiel. Wird vom Gameobject Life aufgerufen.
 */
public class Life : MonoBehaviour
{
    private GameObject score;
    private int life;
    private TextMeshPro text;
    // Start is called before the first frame update
    /**
     * Initilaisierung der Leben auf 3 als auch dass das an den TextmeshPro übertragen wird
     */
    void Start()
    {
        score = GameObject.Find("Score");
        if (score.GetComponent<Score>().GetLevel() == 1)
        {
            PlayerPrefs.SetInt("Life", 3);
        }

        text = this.GetComponent<TextMeshPro>();
    }

    /**
     * methode um die Leben um 1 zu verringern
     */
    public void DecreaseLife()
    {
        life = PlayerPrefs.GetInt("Life", 0) - 1;
        PlayerPrefs.SetInt("Life", life);
    }

    /**
     * methode um die derzeitige Anzahl der Leben zu bekommen
     */
    public int GetLife()
    {
        return PlayerPrefs.GetInt("Life", 0);
    }

    // Update is called once per frame
    /**
     * Schreibt jedes Mal auf, wie viel Leben der Spieler zurzeit hat
     */
    void Update()
    {
        text.text = "Life:" + PlayerPrefs.GetInt("Life",0);
    }
}
