using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private Rigidbody projectile;
    public FloatData projectileSpeed;
   // dont need this public FloatData value;
    public FloatData projectileUpgrade;

	// Use this for initialization
	void Start ()
    {
        projectile = GetComponent<Rigidbody>();
        projectile.AddForce(0,0,projectileSpeed.Value);       
	}

    private void OnTriggerEnter(Collider other)
    {
        projectileSpeed = projectileUpgrade;
        projectile.AddForce(0, 0, projectileSpeed.Value);
    }
}
