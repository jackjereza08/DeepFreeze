using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour 
{
	public float jetpackForce = 75.0f;  
	public float forwardMovementSpeed = 3.0f;
	private Rigidbody2D playerRigidbody;  
	// Use this for initialization
	void Start () 
	{
		playerRigidbody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()   
	{     
		bool jetpackActive = Input.GetButton("Fire1");     
		if (jetpackActive)     
		{         
			playerRigidbody.AddForce(new Vector2(0, jetpackForce));     
		}  
		Vector2 newVelocity = playerRigidbody.velocity;
		newVelocity.x = forwardMovementSpeed;
		playerRigidbody.velocity = newVelocity;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
