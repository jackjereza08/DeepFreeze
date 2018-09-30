using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text ScoreCountText;
	public Text GameOverText;
	float Score;

	public bool StopScoring;
	// Use this for initialization
	void Start () {
		StartCoroutine(Scoring());
		GameOverText.text = "";
	}

	IEnumerator Scoring()
	{
		Score = 0f;
		while(!StopScoring)
		{
			yield return new WaitForSeconds(1f);
			Score +=1;
			ScoreCountText.text = Score.ToString();
		}

		if(StopScoring)
		{
			Debug.Log("GAME OVER");
			GameOverText.text = "GAME OVER";
		}
	}
}
