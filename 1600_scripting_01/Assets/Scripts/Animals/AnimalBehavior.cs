using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour {

    public Animal AnimalInfo;



    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Hit");
    }
}
