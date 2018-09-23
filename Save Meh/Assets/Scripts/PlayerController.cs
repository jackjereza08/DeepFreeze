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
		MoveHorizontal = Input.GetAxisRaw("Horizontal");
		MoveVertical = Input.GetAxisRaw("Vertical");
		Movement = new Vector2(MoveHorizontal,MoveVertical);
		rigid.AddForce(Movement * speed);
	}
}