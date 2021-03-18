using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TableMainMenuPlane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Performer()
    {
        SceneManager.LoadScene("PerformerKeyboard");
    }
    
    public void HighscoreTable()
    {
        
        SceneManager.LoadScene("Highscore");
    }
    
    public void Eintragen()
    {
        
        SceneManager.LoadScene("HighscoreKeyboard");
    }
}
