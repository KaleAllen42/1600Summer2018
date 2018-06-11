using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu]
public class CharacterStats : ScriptableObject	
{
	[Range(0,100)] public float Stats;


}
