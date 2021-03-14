using UnityEngine;
using TMPro;
public class Buttons : MonoBehaviour
{
    private string word;
    private GameObject plane;
    private bool uppercase;
    private TextMeshPro text;
    
    // Start is called before the first frame update
    void Start()
    {
        uppercase = false;
        text = this.GetComponent<TextMeshPro>();
        plane=GameObject.Find("Plane");
        word ="";
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = word;
    }
    
    public void AlphabetFunction (string alphabet)
    {
        if (uppercase)
        {
            alphabet = alphabet.ToUpper();
        }
        if (word.Length <9)
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

    public void SetUpperCase()
    {
        if (uppercase)
        {
            uppercase = false;
        }
        else
        {
            uppercase = true;
        }
    }
    public void EnterFunction()
    {
        PlayerPrefs.SetString("Performer", word);
        plane.GetComponent<GetCameraPerformer>().Stop();
    }


    
    
}
