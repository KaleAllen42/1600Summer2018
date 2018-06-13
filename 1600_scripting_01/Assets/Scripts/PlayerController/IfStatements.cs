using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
[CreateAssetMenu]
public class IfStatements : ScriptableObject
{


	public int a;
	public int b;
	public int c;
	
	private void OnEnable()
	{
		if (a+b ==c)
		{
			Debug.Log("True...Maths.");
			
		}
		else
		{
			Debug.Log("false.");
		}

		if (a + b != c)
		{
			Debug.Log("!=");
		}
		
	}
}
