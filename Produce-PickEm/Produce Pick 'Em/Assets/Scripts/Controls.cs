using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
		{
			gameObject.transform.Translate(-1*Time.deltaTime*speed,0,0,Space.World);
		}
		if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
		{
			gameObject.transform.Translate(1*Time.deltaTime*speed,0,0,Space.World);
		}

		if(Input.GetKey(KeyCode.C))
		{
			//open credits
		}
	}
	void FixedUpdate()
	{
         Vector3 movement = new Vector3 (Input.acceleration.x, 0.0f, 0.0f);
         gameObject.GetComponent<Rigidbody2D>().velocity = movement * speed*7.5f;
     }
}
