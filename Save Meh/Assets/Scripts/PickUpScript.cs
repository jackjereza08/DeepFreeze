using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Speedboost"))
		{
			StartCoroutine(PickupSpeedboost(other));
		}
		else if(other.gameObject.CompareTag("Sheild"))
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
		PlayerStatsScript stats = GetComponent<PlayerStatsScript>();
		stats.SpeedboostCount = 8;
		speedboost.gameObject.SetActive(false);
		yield return new WaitForSeconds(5);
		stats.SpeedboostCount = 4;
		Destroy(speedboost.gameObject);
	}

	//Sheild Generator
	IEnumerator PickupSheild(Collider2D sheild)
	{
		Debug.Log("Sheild picked up");
		PlayerStatsScript stats = GetComponent<PlayerStatsScript>();
		stats.sheildCount = 5;
		sheild.gameObject.SetActive(false);
		yield return new WaitForSeconds(stats.sheildCount);
		stats.sheildCount = 0;
		Destroy(sheild.gameObject);
	}

	//Poisonware Generator
	IEnumerator PickupPoisonware(Collider2D poisonware)
	{
		Debug.Log("Poisonware picked up");
		PlayerStatsScript stats = GetComponent<PlayerStatsScript>();
		stats.PoisonwareCount = 5;
		poisonware.gameObject.SetActive(false);
		yield return new WaitForSeconds(stats.PoisonwareCount);
		stats.PoisonwareCount = 0;
		Destroy(poisonware.gameObject);
	}
}
