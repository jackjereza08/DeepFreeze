using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {

	public Image WMSU;
	public Image ICS;
	public Image DF;

	public Text Presents;

	// Use this for initialization
	void Start () {
		WMSU.enabled = false;
		ICS.enabled = false;
		DF.enabled = false;
		Presents.enabled = false;
		StartCoroutine(ShowLogos());
	}
	
	IEnumerator ShowLogos()
	{
		yield return new WaitForSeconds(2);
		WMSU.enabled = true;
		ICS.enabled = true;
		yield return new WaitForSeconds(2);
		WMSU.enabled = false;
		ICS.enabled = false;
		DF.enabled = true;
		Presents.enabled = true;
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene(1);
	}
}
