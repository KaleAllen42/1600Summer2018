using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
	public GameObject Ai;
	public Transform Destination;
	public Level CurrentLevel;
	private int aiCount;
	

	// Use this for initialization
	void Start ()
	{
		aiCount = CurrentLevel.AiCount;
		StartCoroutine(StartSpawn());
	}

	private IEnumerator StartSpawn()
	{
		while (aiCount > 0)
		{
			GameObject newAi = Instantiate(Ai);
			newAi.GetComponent<AiMovement>().Destination = Destination;
			yield return new WaitForSeconds(CurrentLevel.Time);
			aiCount--;
		
		}
		
		//round++
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
