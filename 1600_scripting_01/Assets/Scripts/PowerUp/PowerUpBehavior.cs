using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PowerUpBehavior : ScriptableObject {

    public PowerUpBase PowerUp;

    private void OnTriggerEnter(Collider other)
    {
        PowerUp.RunPowerUp();
       //gameObject.SetActive(false);
    }
}

