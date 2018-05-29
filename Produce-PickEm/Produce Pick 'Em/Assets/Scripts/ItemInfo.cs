using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour {

	public bool isHealthy;
	public int scoreValue;
	public string itemName;

	public void FixedUpdate()
	{
		if(gameObject.transform.position.y < -10f)
		{
			Destroy(this.gameObject);
		}
	}
	
}
