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
	public float JumpSpeed = 50.0f;
	public float ForwardMovement;
	public float SprintingSpeed = 200.0f;
	public float DefaultSpeed = 10.0f;
	public WeaponBase Weapon;



	// Use this for initialization
	void Start()
	{
		controller = GetComponent<CharacterController>();
		
	}

	// Update is called once per frame
	void Update()
	{
		// defining player movement
		ForwardMovement = DefaultSpeed;
		Speedness = DefaultSpeed;
		//defining axis speed was already taken so I used a nonword speedness
		newPosition.x = Speedness * Input.GetAxis("Horizontal");
		// this allows for jumping
		if (Input.GetKeyDown(KeyCode.Space))
		{
			newPosition.y = JumpSpeed;
		}




		//declares gravity
		newPosition.y -= Gravity;
		// gets forward movement, for some reason unity calls vertical for the Z axis... but I guess up is the Y axis...
		// which is???	
		newPosition.z = ForwardMovement * Input.GetAxis("Vertical");
		// defines default update speed. 10 units per second.
		controller.Move(newPosition * Time.deltaTime);

		// defines sprinting
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			DefaultSpeed += SprintingSpeed;
		}

		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			DefaultSpeed = 10.0f;
		}


		if (Input.GetKeyDown(KeyCode.E))
		{
			print(Weapon.WeaponDamage); 

		}


	}
}
