using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{


	private CharacterController controller;
	private Vector3 newPosition;
	public float Speedness;
	public float Gravity = 9.81f;
	public float JumpSpeed = 50.0f;
	public float ForwardMovement;
	public float SprintingSpeed = 2000.0f;
	public float DefaultSpeed = 10.0f;
	
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		ForwardMovement = DefaultSpeed;
		Speedness = DefaultSpeed;
		newPosition.x = Speedness * Input.GetAxis("Horizontal");
		if (Input.GetKeyDown(KeyCode.Space))
		{
			newPosition.y = JumpSpeed;
		}


		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			DefaultSpeed += SprintingSpeed;
		}

		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			DefaultSpeed = 10.0f;
		}
		
	newPosition.y -= Gravity;
		newPosition.z = ForwardMovement * Input.GetAxis("Vertical");
		controller.Move(newPosition * Time.deltaTime);
	}
}
