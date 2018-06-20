using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class ThirdPersonPlayer : MonoBehaviour
{
	private CharacterController controller;
	private Vector3 newPosition;
	public Vector3 jump;
	private Vector3 Offset;
	public float jumpForce = 100.0f;
	public float Gravity = 9.81f;
	public float SprintingSpeed = 20.0f;
	public float DefaultSpeed = 10.0f;
	public float rotatespeed = 1110.0f;
	public GameObject player;
	public WeaponBase Weapon;
	

	void Start()
	{
		controller = GetComponent<CharacterController>();
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		Offset = player.transform.position - transform.position;
		//jump = new Vector3(0.0f, -2.0f, 0.0f);

	}

	 void Update()
	{
		
		
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
		
		
		jump -= new Vector3(0, Gravity, 0) * Time.deltaTime;
		//transform.position = player.transform.position - ( newPosition * Gravity);
		float horizontal = Input.GetAxis("Mouse X") * rotatespeed;
		controller.transform.Rotate(0, horizontal, 0);
		float desiredAngle = player.transform.eulerAngles.y;
		Quaternion roatation = Quaternion.Euler(0, desiredAngle, 0);
		transform.position = player.transform.position - (roatation * Offset);
		
		
		if (Input.GetKey(KeyCode.Q) && controller.isGrounded);     
		{
			controller.transform.position += jump * jumpForce;
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
