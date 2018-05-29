using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerCollector : MonoBehaviour {

	public int heartCount;
	public int score;
	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;
	public TextMeshProUGUI scoreText;
	public void Start()
	{
		score = 0;
		heartCount = 3;
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.GetComponent<ItemInfo>() != null)
		{
			//Debug.Log("Collected: " + col.gameObject.name);

			if(col.gameObject.GetComponent<ItemInfo>().isHealthy)
			{
				score += col.gameObject.GetComponent<ItemInfo>().scoreValue;

				if(col.gameObject.GetComponent<ItemInfo>().itemName == "Heart")
				{
					CheckHearts(true);
				}
			}
			else
			{
				score += col.gameObject.GetComponent<ItemInfo>().scoreValue;
				CheckHearts(false);
			}

			UpdateScore();
			Destroy(col.gameObject);
		}
	}

	public void CheckHearts(bool addHeart)
	{
		if(addHeart)
		{
			heartCount++;

			if(heartCount >3)
			{
				heartCount = 3;
			}
			UpdateHeartGUI();
		}
		else
		{
			heartCount--;
			UpdateHeartGUI();
			if(heartCount <= 0)
			{
				heart1.SetActive(false);
				heart2.SetActive(false);
				heart3.SetActive(false);
				EndGame();
			}
			
		}
	}

	public void UpdateHeartGUI()
	{
		if(heartCount == 3)
		{
			heart1.SetActive(true);
			heart2.SetActive(true);
			heart3.SetActive(true);
		}
		else if(heartCount == 2)
		{
			heart1.SetActive(true);
			heart2.SetActive(true);
			heart3.SetActive(false);
		}
		else if(heartCount == 1)
		{
			heart1.SetActive(true);
			heart2.SetActive(false);
			heart3.SetActive(false);
		}
	}
	public void UpdateScore()
	{
		scoreText.text = "Score: " + score.ToString();
	}

	public void EndGame()
	{

	}

	
}
