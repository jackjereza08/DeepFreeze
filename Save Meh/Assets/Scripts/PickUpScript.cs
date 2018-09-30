using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpScript : MonoBehaviour 
{

	public Image speedboostImage;
	public Image shieldImage;
	public Image poisonwareImage;

	void Start()
	{
		speedboostImage.enabled = false;
		shieldImage.enabled = false;
		poisonwareImage.enabled = false;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Speedboost"))
		{
			StartCoroutine(PickupSpeedboost(other));
		}
		else if(other.gameObject.CompareTag("Shield"))
		{
			StartCoroutine(PickupSheild(other));
		}
		else if(other.gameObject.CompareTag("Poisonware"))
		{
			StartCoroutine(PickupPoisonware(other));
		}
	}

	//Speedboost Generator.
	IEnumerator PickupSpeedboost(Collider2D speedboost)
	{
		Debug.Log("Speedboost picked up");
		speedboostImage.enabled = true;
		PlayerStatsScript stats = GetComponent<PlayerStatsScript>();
		stats.SpeedboostCount = 8;
		speedboost.gameObject.SetActive(false);
		yield return new WaitForSeconds(5);
		stats.SpeedboostCount = 4;
		speedboostImage.enabled = false;
		Destroy(speedboost.gameObject);
	}

	//Sheild Generator
	IEnumerator PickupSheild(Collider2D sheild)
	{
		Debug.Log("Shield picked up");
		shieldImage.enabled = true;
		PlayerStatsScript stats = GetComponent<PlayerStatsScript>();
		stats.sheildCount = 5;
		sheild.gameObject.SetActive(false);
		yield return new WaitForSeconds(stats.sheildCount);
		stats.sheildCount = 0;
		shieldImage.enabled = false;
		Destroy(sheild.gameObject);
	}

	//Poisonware Generator
	IEnumerator PickupPoisonware(Collider2D poisonware)
	{
		Debug.Log("Poisonware picked up");
		poisonwareImage.enabled = true;
		PlayerStatsScript stats = GetComponent<PlayerStatsScript>();
		stats.PoisonwareCount = 5;
		poisonware.gameObject.SetActive(false);
		yield return new WaitForSeconds(stats.PoisonwareCount);
		stats.PoisonwareCount = 0;
		poisonwareImage.enabled = false;
		Destroy(poisonware.gameObject);
	}
}
