using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatRounds : MonoBehaviour
{

	//public int CurrentRound;
	//public WeaponBase WeaponBase;
	public float CurrentHealth;
	public float WeaponDamage;
	//public float MaxHealth = 10.0f;
	//public string PlayerName;
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

		// IDEA Make a number for rounds then cound up rounds and spawn like 3 units, then next round up it to like 5 etc
		//IEnumerator Ticker()   );
		//{
		// While (i > 0)
		//	DisplayText.text = i.ToString();
		//yield return WaitForSeconds(10);
		//	i--;
			
		//}
		
		
		//Display.text = "Round 1";
		//yield return WaitForSeconds(10);
		//Display.text = "";
		
		//Set round to 2
		//spawn droids 

		//Display.text = "Round 2";


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
