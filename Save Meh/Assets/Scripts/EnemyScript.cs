using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour 
{

	public float speed;
	public float stoppingDistance;
	private Transform target;
	public bool stop;
	// Use this for initialization
	void Start () 
	{
		target =  GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		StartCoroutine(CatchPlayer());
	}
	
	IEnumerator CatchPlayer() 
	{
		while(!stop)
		{
			if(Vector2.Distance(transform.position,target.position) > stoppingDistance)
			{
				transform.position = Vector2.MoveTowards(transform.position,target.position,speed * Time.deltaTime);
			}
			else
			{
				PlayerStatsScript stats = target.GetComponent<PlayerStatsScript>();

				//If player has sheild the enemy will destroy.
				if(stats.sheildCount != 0)
				{
					Debug.LogWarning("Sheild Detected");
					Destroy(gameObject);
				}
				else
				{
					Debug.Log("Collision Detected");
					ScoreScript score = target.GetComponent<ScoreScript>();
					score.StopScoring = true;
					stop = true;
				}
			}
			yield return new WaitForSeconds(0.0f);
		}
	}
}
