using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
public float speed=3.0f;
private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=this.GetComponent<Rigidbody2D>();
		rb.velocity=new Vector2(-speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-6){
		Destroy(this.gameObject);
    }

	void IncreaseSpeed(float inc){
		speed=speed+inc;
	}
}
}
