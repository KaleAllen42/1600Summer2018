using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu]
public class DoAddition : ScriptableObject
{
	public int c;

	private void OnEnable()
	{
		c = Run(10, 2);
		
	}

	public int Run(int a, int b)
	{
		return a += b;
	}
}
