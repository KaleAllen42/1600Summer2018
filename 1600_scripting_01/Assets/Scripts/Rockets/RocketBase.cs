using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]


public class RocketBase : ScriptableObject

{

    [Range(-10, 10)] public float PowerLevel = 10.0f;
}
