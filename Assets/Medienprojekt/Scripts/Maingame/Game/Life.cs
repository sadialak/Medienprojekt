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
    public Sprite[] array;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    /**
     * Initilaisierung der Leben auf 3 als auch dass das an den TextmeshPro übertragen wird
     */
    void Start()
    {
        sprite=this.GetComponent<SpriteRenderer>();
        score = GameObject.Find("Score");
        if (score.GetComponent<Score>().GetLevel() == 1)
        {
            PlayerPrefs.SetInt("Life", 5);
        }

        
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
        if (PlayerPrefs.GetInt("Life")<5)
        {
            sprite.sprite = array[0];
        }
        if (PlayerPrefs.GetInt("Life")<4)
        {
            sprite.sprite = array[1];
        }
        if (PlayerPrefs.GetInt("Life")<3)
        {
            sprite.sprite = array[2];
        }
        if (PlayerPrefs.GetInt("Life")<2)
        {
            sprite.sprite = array[3];
        }
        if (PlayerPrefs.GetInt("Life")<1)
        {
            sprite.sprite = array[4];
        }
    }
}
