using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDropper : MonoBehaviour {

	public GameObject[] foods;
	public float dropInterval;
	private float time;
	private BoxCollider2D coll;
	// Use this for initialization
	void Start () 
	{
		time = dropInterval;	
		coll = gameObject.GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(time <=0 )
		{
			DropFood();
			time = dropInterval;
		}
		else
		{
			time -= Time.deltaTime;
		}
	}

	public void DropFood()
	{
		GameObject clone = Instantiate(foods[Random.Range(0,foods.Length)],new Vector3(Random.Range(coll.bounds.min.x,coll.bounds.max.x),coll.bounds.center.y,0),transform.rotation);
	}
}
