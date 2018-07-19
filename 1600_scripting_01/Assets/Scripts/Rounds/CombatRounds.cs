using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
	public Text RoundText;
	public int i = 10;
	public int Round = 1;
	public bool RoundComplete = false;

	void Start()
	{
		CurrentHealth = 10;
		StartCoroutine (    Ticker()  );

		for (int i = 0; i < Droids.Count; i++)
		{
			Droids[i].SetActive((true));
			Round++;

		}
	}
	//WIP
	void Update()
	{
		if (Droids.Count < 1)
		{
			RoundComplete = true;
		}
		
		
	}


	// IDEA Make a number for rounds then round up rounds and spawn like 3 units, then next round up it to like 5 etc
		IEnumerator Ticker()
		{
			while (RoundComplete)
			{
				RoundText.text = i.ToString("Next round in:");
				yield return new WaitForSeconds(10);
				i--;
				RoundComplete = false;

			}

			if (Round == 2)
			{
				Droids[i].SetActive((true));
			}
		}
		
	
		
		//Display.text = "Round 1";
		//yield return WaitForSeconds(10);
		//Display.text = "";
		
		//Set round to 2
		//spawn droids 

		//Display.text = "Round 2";


	
	private void OnTriggerEnter()
	{
		DamageEvent.Value -= HealthEvent.Value;
		WeaponDamage -= CurrentHealth;
		if (HealthEvent.Value >= 0)
		{
			Droid.SetActive(false); 
		}

		
		
	}
}
