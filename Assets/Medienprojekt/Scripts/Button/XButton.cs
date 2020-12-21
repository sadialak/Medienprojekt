using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XButton : MonoBehaviour
{
	private GameObject score;
	private GameObject life;
    private int spritezahl;
    private SpriteRenderer sprite;
    public Sprite[] array;
    private float speed;
    private Rigidbody2D rb;
    private PlayerControls controls;
    // Start is called before the first frame update
    void Awake()
    {
        spritezahl = 0;
        life=GameObject.Find("Life");
		score=GameObject.Find("Score");
        speed=3.0f;
        sprite=this.GetComponent<SpriteRenderer>();
        controls=new PlayerControls();
        rb=this.GetComponent<Rigidbody2D>();
        rb.velocity=new Vector2(-speed,0);
        controls.Gameplay.XSmash.performed+=ctx =>  XTrigger();
        controls.Gameplay.ASmash.performed+=ctx =>  ATrigger();
        controls.Gameplay.BSmash.performed+=ctx =>  BTrigger();
        controls.Gameplay.YSmash.performed+=ctx =>  YTrigger();
    }

    void IncreaseSpeed(float inc){
        speed=inc;
        rb.velocity=new Vector2(-speed,0);
    }

    void XTrigger(){
        if (spritezahl == 0)
        {
            if (transform.position.x < 0.5 && transform.position.x > -0.5)
            {
                Destroy(this.gameObject);
				score.GetComponent<Score>().IncreaseScore(50);
            }
            else
            {
                sprite.sprite = array[1];
                spritezahl = 1;
				score.GetComponent<Score>().IncreaseScore(-10);
				life.GetComponent<Life>().DecreaseLife();
            }
        }
    }

    void ATrigger(){
        if (spritezahl == 0)
        {
            sprite.sprite = array[1];
            spritezahl = 1;
			score.GetComponent<Score>().IncreaseScore(-10);
			life.GetComponent<Life>().DecreaseLife();
        }
    }

    void BTrigger(){
        if (spritezahl == 0)
        {
            sprite.sprite = array[1];
            spritezahl = 1;
			score.GetComponent<Score>().IncreaseScore(-10);
			life.GetComponent<Life>().DecreaseLife();
        }
    }

    void YTrigger(){
        if (spritezahl == 0)
        {
            sprite.sprite = array[1];
            spritezahl = 1;
			score.GetComponent<Score>().IncreaseScore(-10);
			life.GetComponent<Life>().DecreaseLife();
        }
    }

    void OnEnable(){
        controls.Gameplay.Enable();
    }

    void OnDisable(){
        controls.Gameplay.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        if (spritezahl == 0)
        {
            if (transform.position.x <= -0.5)
            {
                sprite.sprite = array[1];
                spritezahl = 1;
				score.GetComponent<Score>().IncreaseScore(-10);
				life.GetComponent<Life>().DecreaseLife();
            }
        }

        if (transform.position.x < -6)
        {
            Destroy(this.gameObject);
        }
    }
}
