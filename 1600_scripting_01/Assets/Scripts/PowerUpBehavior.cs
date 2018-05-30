using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour {

    public PowerUpBase PowerUp;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}

