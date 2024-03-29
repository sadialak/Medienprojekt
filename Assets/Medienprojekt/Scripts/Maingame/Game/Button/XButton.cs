﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
* Verhalten und Eigenschaften von Button X (sobald es Instanziiert wird).
* Hierbei wird auch geregelt, was passiert, wenn der entsrpechende Controller
* Input gedrückt wird.
*/
public class XButton : MonoBehaviour
{
	
	private GameObject score;
	private GameObject life;
    private int spritezahl;
    private SpriteRenderer sprite;
    public Sprite[] array;
    public float speed;
    private Rigidbody2D rb;
    private PlayerControls controls;
	
    // Start is called before the first frame update
	/**
	* Bei der Awake Function werden die GameObjecte Life und Score Initialsiert als auch zu den 
	* entsprechenden Funktionen gefürht, wenn die entsprechenden Button A,B,X,Y gedrückt werden.
	* Außerdem wird die Geschwindigkeit gesetzt und was im Spiel mit dem Passieren soll
	* (In dem Fall dass es von rechts nach links geht). Zudem wird mit sprite das Aussehen des Buttons geregelt.
	*/
    void Awake()
    {
	    
        spritezahl = 0;
        life=GameObject.Find("Life");
		score=GameObject.Find("Score");
        speed=2.7f;
        sprite=this.GetComponent<SpriteRenderer>();
        controls=new PlayerControls();
        rb=this.GetComponent<Rigidbody2D>();
        rb.velocity=new Vector2(0,-speed);
        controls.Gameplay.XSmash.performed+=ctx =>  XTrigger();
        controls.Gameplay.ASmash.performed+=ctx =>  ATrigger();
        controls.Gameplay.BSmash.performed+=ctx =>  BTrigger();
        controls.Gameplay.YSmash.performed+=ctx =>  YTrigger();
    }

	/**
	* Hierbei wird die Gescwhwindigkeit um den Übergabeparameter erhöht (wird nicht addiert sondern ist dann genau dem übergabeparameter hoch)
	*/
    void IncreaseSpeed(float inc){
        speed=inc;
        rb.velocity=new Vector2(0,-speed);
    }

	/**
	* Verhalten was passiert, wenn X gedrückt wird. Dabei wird sprite zum foul verändert, der sound X abgespielt und die Leben um 1 verringert, sollte X
	* zu früh gedrückt werden. Andernfalls wird das Objekt zerstört und die Punktzahl um 50 erhöht und der X sound abgespielt.
	* kann nur einmal passieren (dafür sorgt spritezahl)
	*/
    void XTrigger(){
        if (spritezahl == 0)
        {
            if (transform.position.y < 0.5 && transform.position.y > -0.5)
            {
                FindObjectOfType<AudioManager>().Play("X");
                Destroy(this.gameObject);
				score.GetComponent<Score>().IncreaseScore(50);
				
				
            }
            else if (transform.position.y <5.0 && transform.position.y >=0.5)
            {
                sprite.sprite = array[1];
                spritezahl = 1;
				 FindObjectOfType<AudioManager>().Play("X");
				life.GetComponent<Life>().DecreaseLife();
            }
        }
    }

	/**
	* Verhalten was passiert, wenn A gedrückt wird. Dabei wird sprite zum foul verändert, der sound A abgespielt und die Leben um 1 verringert.
	* kann nur einmal passieren (dafür sorgt spritezahl)
	*/
    void ATrigger(){
        if (spritezahl == 0 &&transform.position.y <5.0 )
        {
            sprite.sprite = array[1];
            spritezahl = 1;
			 FindObjectOfType<AudioManager>().Play("A");
			life.GetComponent<Life>().DecreaseLife();
        }
    }

	/**
	* Verhalten was passiert, wenn B gedrückt wird. Dabei wird sprite zum foul verändert, der sound B abgespielt und die Leben um 1 verringert.
	* kann nur einmal passieren (dafür sorgt spritezahl)
	*/
    void BTrigger(){
        if (spritezahl == 0 &&transform.position.y <5.0 )
        {
            sprite.sprite = array[1];
            spritezahl = 1;
			 FindObjectOfType<AudioManager>().Play("B");
			life.GetComponent<Life>().DecreaseLife();
        }
    }

	/**
	* Verhalten was passiert, wenn Y gedrückt wird. Dabei wird sprite zum foul verändert, der sound Y abgespielt und die Leben um 1 verringert.
	* kann nur einmal passieren (dafür sorgt spritezahl)
	*/
    void YTrigger(){
        if (spritezahl == 0 &&transform.position.y <5.0 )
        {
            sprite.sprite = array[1];
            spritezahl = 1;
			 FindObjectOfType<AudioManager>().Play("Y");
			life.GetComponent<Life>().DecreaseLife();
        }
    }

	/**
	* Controllereingaben werden durch die beiden unteren Funktionen reguliert.
	*/
    void OnEnable(){
        controls.Gameplay.Enable();
    }

    void OnDisable(){
        controls.Gameplay.Disable();
    }
    // Update is called once per frame
	/**
	* Hier wird geguckt was passiert, wenn der Button zu spät gedrückt wird (ändert sich zu Foul und Lebensverlust. Ohne Sound abspielen) und
	* wenn eine gewisse Punktzahl erreicht wird für Level 2. In dem Fall erhöht sich noch einmal die Geschwindigket. Auch wird am Ende
	* des Balkens dann auf jeden Fall das Objekt spätestens zerstört.
	*/
    void Update()
    {
        if(score.GetComponent<Score>().GetLevel()==2){
            IncreaseSpeed(4f);
        }
        if (spritezahl == 0)
        {
            if (transform.position.y <= -0.5)
            {
                sprite.sprite = array[1];
                spritezahl = 1;
				
				life.GetComponent<Life>().DecreaseLife();
            }
        }

        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }
}
