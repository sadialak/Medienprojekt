using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreKeyboard : MonoBehaviour
{
    private Text text;

    private string word;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
        word ="";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = word;
    }
    
    public void AlphabetFunction (string alphabet)
    {
        if (word.Length < 9)
        {
            word = word + alphabet;
        }
    }
    
    public void RemoveFunction ()
    {
        if (word.Length >= 1)
        { 
            word = word.Remove(word.Length - 1, 1); 
            
        }

    }
    
    public void EnterFunction()
    {
        int a = Convert.ToInt32(word);
        PlayerPrefs.SetInt("Score", a);
        SceneManager.LoadScene("Highscore");
    }
}
