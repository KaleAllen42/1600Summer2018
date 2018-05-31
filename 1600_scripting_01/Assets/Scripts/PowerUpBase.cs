using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
   {
       public Animal2 AnyAnimal; 
       public float PowerLevel = 1.0f;
       public void RunPowerUp()
    {
        //AnyAnimal.Health += PowerLevel;
    }
   }
