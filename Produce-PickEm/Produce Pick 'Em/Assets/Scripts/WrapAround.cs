using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapAround : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(gameObject.transform.position.x < -7.4)
		{
			gameObject.transform.position = new Vector3(7.3f,-3.71f,0);
		}
		if(gameObject.transform.position.x > 7.4)
		{
			gameObject.transform.position = new Vector3(-7.3f,-3.71f,0);
		}
	
	}
}
