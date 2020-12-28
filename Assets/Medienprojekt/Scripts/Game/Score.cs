using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{

    private int score;

    private TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        text = this.GetComponent<TextMeshPro>();
    }

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
    void Update()
    {
       
        text.text = "Score:" + score;
    }
}
