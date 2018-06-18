using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class CameraController : MonoBehaviour
{

	public GameObject player;
	public float rotateSpeed = 5;
	private Vector3 Offset;
	
	// Use this for initialization
	void Start ()
	{
		Offset = player.transform.position - transform.position;
	}

	private void LateUpdate()
	{
		float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
		player.transform.Rotate(0, horizontal, 0);
		

		float desiredAngle = player.transform.eulerAngles.y;
		Quaternion roatation = Quaternion.Euler(0, desiredAngle, 0);
		transform.position = player.transform.position - (roatation * Offset);
		transform.LookAt(player.transform);
	}
}
