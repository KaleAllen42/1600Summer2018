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
	

	private void Start()
	{
		DamageEvent = WeaponBase.WeaponDamage;
		HealthEvent = HealthBase.HealthValue;

	}


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


