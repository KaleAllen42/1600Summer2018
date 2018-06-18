using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Experimental.UIElements;


public class MovePlayer : MonoBehaviour
{

	private CharacterController controller;
	private Vector3 newPosition;
	public float Speedness;
	public float Gravity = 9.81f;
	public float JumpSpeed = 30.0f;
	public float ForwardMovement;
	public float SprintingSpeed = 20.0f;
	public float DefaultSpeed = 10.0f;
	public WeaponObject DoDamage;
	public bool CanRun  = false; 



	// Use this for initialization
	void Start()
	{
		controller = GetComponent<CharacterController>();
		CanRun = false;	

	}

	// Update is called once per frame
	void Update()
	{
	// defining player movement
	ForwardMovement = DefaultSpeed;
	Speedness = DefaultSpeed;
	// Makes player able to move or not move. 
	
	//defining axis speed was already taken so I used a nonword speedness
	newPosition.x = Speedness * Input.GetAxis("Horizontal");
	// gets forward movement, for some reason unity calls vertical for the Z axis... but I guess up is the Y axis...
	// which is???	
	newPosition.z = ForwardMovement * Input.GetAxis("Vertical");
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			CanRun = true;
		}
		
		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			CanRun = false;
		}
		// this allows for jumping
		if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
		{
			newPosition.y = JumpSpeed;
		}
	
	//declares gravity
	newPosition.y -= Gravity;	
	// defines default update speed. 10 units per second.
	controller.Move(newPosition * Time.deltaTime);

		
		// defines old sprinting method
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			DefaultSpeed += SprintingSpeed;
		}

		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			DefaultSpeed = 10.0f;
		}

		if (Input.GetMouseButtonDown(0))
		{
			print(DoDamage.DamageLevel);
		}
		


	}
}
