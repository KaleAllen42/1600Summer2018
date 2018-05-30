using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour {

    public PowerUpBase PowerUp;

    private void OnTriggerEnter(Collider other)
    {
        PowerUp.RunPowerUp();
        gameObject.SetActive(false);
    }
}

