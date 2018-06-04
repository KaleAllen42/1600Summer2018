using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{

   [Range(0,1)] public float Value;
}
