using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour {
	
	private CharacterController controller;
	private Vector3 newPosition;
	public float gravity = 20f;
	public float SprintingSpeed = 20.0f;
	public float DefaultSpeed = 10.0f;
	public float rotatespeed = 5.0f;
	public GameObject player;
	public WeaponBase Weapon;
	private Vector3 moveDirection = Vector3.zero;
	public float jumpForce = 0.01f;
	private Vector3 Offset;


	// Use this for initialization
	void Start () 
	{
		controller = GetComponent<CharacterController>();
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		
	}
	
	
	
	
	// Update is called once per frame
	void Update()
	{

		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded)
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= DefaultSpeed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpForce;
		}
		
		// defines sprinting method
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
		
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
		
		
		
		float horizontal = Input.GetAxis("Mouse X") * rotatespeed;
		player.transform.Rotate(0, horizontal, 0);
		float desiredAngle = player.transform.eulerAngles.y;
		Quaternion roatation = Quaternion.Euler(0, desiredAngle, 0);
		transform.position = player.transform.position - (roatation * Offset);
	}
}
