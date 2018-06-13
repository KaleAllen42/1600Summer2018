using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{


	public FloatData HealthLevel;
	public FloatData EvilPower;

	
	// Use this for initialization
	void Start()
	{
		//for formating
		

	}



	void OnTriggerEnter()
	{
		
		// this is the most awful way to do the code
		HealthLevel.Value -= EvilPower.Value;
		//PlayerHealthBehavior.HealthLevel = HealthLevel;
	

	}
}
