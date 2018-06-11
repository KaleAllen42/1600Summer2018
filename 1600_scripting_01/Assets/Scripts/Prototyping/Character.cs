using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
	void  Update()
	{
		if (Input.GetKey(KeyCode.W))
			print("w");
		if (Input.GetKey(KeyCode.S))
			print("s");
		if (Input.GetKey(KeyCode.D))
			print("d");
		if (Input.GetKey(KeyCode.A))
			print("a");
		}
	
}
