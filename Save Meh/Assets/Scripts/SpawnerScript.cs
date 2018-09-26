using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour 
{

	public GameObject enemy;
	public GameObject[] pickups;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnLeastWait;
	public float spawnMostWait;
	public int startSpawnWait;
	public int randomPickUps;
	public bool stop;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(WaitSpawner());
	}
	
	// Update is called once per frame
	void Update () 
	{
		spawnWait = Random.Range(spawnLeastWait,spawnMostWait);
	}

	IEnumerator WaitSpawner()
	{
		yield return new WaitForSeconds(startSpawnWait);

		while(!stop)
		{
			randomPickUps = Random.Range(0,3);
			Vector3 spawnPos = new Vector3(Random.Range(-spawnValues.x,spawnValues.x),Random.Range(-spawnValues.y,spawnValues.y));
			Instantiate(enemy,spawnPos,gameObject.transform.rotation);
			Vector3 spawnPos1 = new Vector3(Random.Range(-spawnValues.x,spawnValues.x),Random.Range(-spawnValues.y,spawnValues.y));
			Instantiate(pickups[randomPickUps],spawnPos1,gameObject.transform.rotation);
			yield return new WaitForSeconds(spawnWait);
		}
	}
}
