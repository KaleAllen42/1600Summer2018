using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour
{

	public Animal2 Animal2Info;
	
	// Use this for initialization
	void Start ()
	{
		print(Animal2Info.Health);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
