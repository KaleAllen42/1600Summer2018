using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
[CreateAssetMenu]
public class WeaponBase : ScriptableObject
{

    public string WeaponName;
    [Range(0,100)]public float WeaponDamage;
    public float weapon;

}
