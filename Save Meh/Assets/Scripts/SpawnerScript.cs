using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour 
{

	public GameObject enemy;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnLeastWait;
	public float spawnMostWait;
	public int startSpawnWait;
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
			Vector3 spawnPos = new Vector3(Random.Range(-spawnValues.x,spawnValues.x),Random.Range(-spawnValues.y,spawnValues.y));
			Instantiate(enemy,spawnPos,gameObject.transform.rotation);
			yield return new WaitForSeconds(spawnWait);
		}
	}
}
