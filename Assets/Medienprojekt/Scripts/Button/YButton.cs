﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YButton : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Sprite[] array;
    private float position;
    private float speed;
    private Rigidbody2D rb;
    private PlayerControls controls;
    // Start is called before the first frame update
    void Awake()
    {
        sprite=this.GetComponent<SpriteRenderer>();
        speed=3.0f;
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
        sprite.sprite = array[1];
    }

    void ATrigger(){
        sprite.sprite = array[1];
    }

    void BTrigger(){
        sprite.sprite = array[1];
    }

    void YTrigger(){
        if (transform.position.x < 0.5 && transform.position.x>-0.5)
        {
            Destroy(this.gameObject);
        }
        else
        {
            sprite.sprite = array[1];
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
        if (transform.position.x <= -0.5)
        {
            sprite.sprite = array[1];
        }
        
        if (transform.position.x < -6)
        {
            Destroy(this.gameObject);
        }
    }
}
