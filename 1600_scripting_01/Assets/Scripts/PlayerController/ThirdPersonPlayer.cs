using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThirdPersonPlayer : MonoBehaviour
{
	
	private Vector3 newPosition;
	//public Vector3 jump;
	private Vector3 Offset;
	//public float jumpForce = 100.0f;
	//public float Gravity = 9.83f;
	public float SprintingSpeed = 20.0f;
	public float DefaultSpeed = 10.0f;
	public float rotatespeed = 5.0f;
	public GameObject player;
	public WeaponBase Weapon;
	//public Vector3 Gravitation;
	//private Vector3 moveDirection = Vector3.zero;
	

	void Start()
	{
		
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		Offset = player.transform.position - transform.position;
		//jump = new Vector3(0.0f, 2.0f, 0.0f);
		
		
		
	}

	 void Update()
	{
		
		//moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		
	if (Input.GetKeyDown(KeyCode.Space))
	    {
			//newPosition.y -= Gravity * jumpForce;
			print("jump");
		}
		
		// Use physics controllers to move them forward, or use the character controller and dont use transform.position!
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
		
			
		//jump -= new Vector3(0, Gravity, 0) * Time.deltaTime;
		//transform.position = player.transform.position - ( newPosition * Gravity);
		float horizontal = Input.GetAxis("Mouse X") * rotatespeed;
		player.transform.Rotate(0, horizontal, 0);
		float desiredAngle = player.transform.eulerAngles.y;
		Quaternion roatation = Quaternion.Euler(0, desiredAngle, 0);
		transform.position = player.transform.position - (roatation * Offset);
		
		

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
