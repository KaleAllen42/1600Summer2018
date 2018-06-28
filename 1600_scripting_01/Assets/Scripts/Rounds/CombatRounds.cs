using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatRounds : MonoBehaviour
{

	public int CurrentRound;
	public WeaponBase WeaponBase;
	public float CurrentHealth;
	public float WeaponDamage;
	public float MaxHealth = 10.0f;
	public string PlayerName;
	public List<GameObject> Droids;
	public GameObject Droid;
	public FloatData DamageEvent;
	public FloatData HealthEvent;

	void Start()
	{
		CurrentHealth = 10;
		
		for (int i = 0; i < Droids.Count; i++)
		{
			Droids[i].SetActive((true));
		}


	}

	private void OnTriggerEnter()
	{
		DamageEvent.Value -= HealthEvent.Value;
		WeaponDamage -= CurrentHealth;
		if (HealthEvent.Value >= 0)
		{
			Droid.active = false;
		}
		
		
	}
}
