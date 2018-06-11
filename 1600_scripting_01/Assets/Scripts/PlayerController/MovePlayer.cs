using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{


	private CharacterController controller;
	private Vector3 newPosition;
	public float Speedness = 10.0f;
	public float Gravity = 9.81f;
	public float JumpSpeed = 50.0f;
	
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		
		newPosition.x = Speedness * Input.GetAxis("Horizontal");
		if (Input.GetKeyDown(KeyCode.Space))
		{
			newPosition.y = JumpSpeed;
		}
		
		newPosition.y -= Gravity;
		//newPosition.z = Speedness * Input.GetAxis("Forward");
		controller.Move(newPosition * Time.deltaTime);
	}
}
