using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    private SpriteRenderer sprite;
	private PlayerControls controls;
	public float respawnTime = 0.5f;
    void Awake()
    {
		controls= new PlayerControls();
        sprite = this.GetComponent<SpriteRenderer>();
		controls.Gameplay.XSmash.performed+=ctx =>  StartCoroutine(SetXColor());
		controls.Gameplay.ASmash.performed+=ctx => StartCoroutine(SetAColor());
		controls.Gameplay.BSmash.performed+=ctx =>  StartCoroutine(SetBColor());
		controls.Gameplay.YSmash.performed+=ctx =>  StartCoroutine(SetYColor());
    }

	IEnumerator SetAColor()
	{
	sprite.color=Color.red;
	yield return new WaitForSeconds(respawnTime);
	sprite.color=Color.white;
	
	}

	IEnumerator SetBColor()
	{
	sprite.color=Color.yellow;
	yield return new WaitForSeconds(respawnTime);
	sprite.color=Color.white;

	}

	IEnumerator SetXColor()
	{
	sprite.color=Color.blue;
	yield return new WaitForSeconds(respawnTime);
	sprite.color=Color.white;

	}

	IEnumerator SetYColor()
	{
	sprite.color=Color.green;
	yield return new WaitForSeconds(respawnTime);
	sprite.color=Color.white;

	}

	void OnEnable(){
	controls.Gameplay.Enable();
	}

	void OnDisable(){
	controls.Gameplay.Disable();
	}
    
}
