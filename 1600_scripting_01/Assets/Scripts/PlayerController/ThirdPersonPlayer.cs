using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ThirdPersonPlayer : MonoBehaviour
{
	private CharacterController controller;
	private Vector3 newPosition;
	public float Gravity = 9.81f;
	public WeaponBase Weapon;
	public float JumpSpeed = 30.0f;
	public float SprintingSpeed = 20.0f;
	public float DefaultSpeed = 10.0f;


	void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	void Update()
	{
		
		newPosition.y -= Gravity;
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += transform.forward * Time.deltaTime * DefaultSpeed;	
		}
		else if (Input.GetKey(KeyCode.S))
		{
			transform.position -= transform.forward * Time.deltaTime * DefaultSpeed;	
		}
		else if (Input.GetKey(KeyCode.D))
		{
			transform.position += transform.right * Time.deltaTime * DefaultSpeed;	
		}
		else if (Input.GetKey(KeyCode.A))
		{
			transform.position -= transform.right * Time.deltaTime * DefaultSpeed;	
		}
		
		if (Input.GetKey(KeyCode.Space) && controller.isGrounded)
		{
			newPosition.y = JumpSpeed;
		}
		
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
			print(Weapon.WeaponDamage);
		}
		
	}
}
