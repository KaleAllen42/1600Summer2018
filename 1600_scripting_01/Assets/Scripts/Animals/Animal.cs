using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu()]
public class Animal : ScriptableObject {

    public float Speed = 1.0f;
    public string PlayerName;
    public float Health = 10.0f;
    public int LegCount = 1;
    public PowerUpBase PowerLevel;

    public PowerUpBase PowerUp;

    public void UpdateHealth();
    {
    // Have the powerUp give us information
    Health += PowerUp.PowerLevel;
    }
}
