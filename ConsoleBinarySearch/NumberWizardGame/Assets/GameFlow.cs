using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour {

	int MinimumNumber = 0;
	int MaximumNumber = 100;
	int CurrentNumber;
	int NumberBefore;
	// Use this for initialization
	
	void Start () 
	{
		Debug.Log("Welcome");
		Debug.Log("Please Pick A Number");
		Debug.Log("The Minimum number is:" + MinimumNumber);
		Debug.Log("The Maximum number is:" + MaximumNumber);
		CurrentNumber = MinimumNumber + MaximumNumber / 2;
		NumberBefore = CurrentNumber;
		Debug.Log("Is your number is:" + CurrentNumber);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown("up"))
        {
        	MinimumNumber = CurrentNumber;
        	CurrentNumber = (CurrentNumber + MaximumNumber) / 2;
            Debug.Log("Is your number is:" + CurrentNumber);
        }
        if (Input.GetKeyDown("down"))
        {        	
			MaximumNumber = CurrentNumber;
            CurrentNumber = (MinimumNumber + CurrentNumber) / 2;          
            Debug.Log("Is your number is:" + CurrentNumber);
        }
	}
}
