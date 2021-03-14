using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownSprite : MonoBehaviour
{
    
    private SpriteRenderer sprite;
    public float startingTime;
    float currentTime = 0f;
    public Sprite[] array;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        sprite=this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 3)
        {
            sprite.sprite = array[0];
        }
        if (currentTime <= 2)
        {
            sprite.sprite = array[1];
        }
        if (currentTime <= 1)
        {
            sprite.sprite = array[2];
        }
        if (currentTime <= 0.1)
        {
            Destroy(this.gameObject);
        }
    }
}
