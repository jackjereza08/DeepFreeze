using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{

	public float speed;
	private float MoveHorizontal;
	private float MoveVertical;
	private Rigidbody2D rigid;
	private Vector2 Movement;
	// Use this for initialization
	void Start () 
	{
		rigid = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () 
	{
		PlayerStatsScript stats = GetComponent<PlayerStatsScript>();
		speed = stats.SpeedboostCount;

		//If the player picked up a poisonware the controll will reverse.
		if(stats.PoisonwareCount != 0)	
		{
			MoveHorizontal = Input.GetAxisRaw("Vertical");
			MoveVertical = Input.GetAxisRaw("Horizontal");
			Movement = new Vector2(MoveHorizontal,MoveVertical);
			rigid.AddForce(Movement * speed);
		}
		else
		{
			MoveHorizontal = Input.GetAxisRaw("Horizontal");
			MoveVertical = Input.GetAxisRaw("Vertical");
			Movement = new Vector2(MoveHorizontal,MoveVertical);
			rigid.AddForce(Movement * speed);
		}
	}
}