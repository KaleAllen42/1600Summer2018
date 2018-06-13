using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
[CreateAssetMenu]
public class EnemyBase : ScriptableObject
{

	public WeaponBase WeaponDamage;
	public float CurrentHealth;
	//public FloatData CurrentHealth;
	public float MaxHealth = 10.0f;
	public string PlayerName;
	
	 void Start()
	 {
		 CurrentHealth = MaxHealth;
		 
	 }

	void OnTriggerEnter()
	{
		//WeaponDamage.value -= 
		if (CurrentHealth >= 0)
		{
			
		}

		

	}
}
