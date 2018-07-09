using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{



	public FloatData DamageEvent;
	public FloatData HealthEvent;
	public WeaponBase WeaponBase;
	public HealthBase HealthBase;
	public GameObject Droid;
	public GameObject Saber;
	public bool canDoDamage;
	

	private void Start()
	{
		//DamageEvent = WeaponBase.WeaponDamage;
		HealthEvent = HealthBase.HealthValue;

	}
	
	
	//Idea, make a bool for CANDodamage, then set it false for like 1 second, then set it to true, so spamming cant happen


	private void OnTriggerEnter(Collider Saber)
		{
			DamageEvent.Value -= HealthEvent.Value;
			if (HealthEvent.Value >= 0)
			{
				Destroy(Droid);
				Debug.Log("Bam");
			}

		}


	}


