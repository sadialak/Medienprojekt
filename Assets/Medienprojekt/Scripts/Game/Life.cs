using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Life : MonoBehaviour
{


    private int life;

    private TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        text = this.GetComponent<TextMeshPro>();
    }

    public void DecreaseLife()
    {
        life--;
    }

    public int GetLife()
    {
        return life;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Life:" + life;
    }
}
