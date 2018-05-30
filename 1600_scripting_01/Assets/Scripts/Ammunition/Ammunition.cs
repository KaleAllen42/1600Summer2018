using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunition : MonoBehaviour {

    public class ammo
    {
        public int Energy;
        public int Rockets;
        public int Power;
        public int Stamina;


        //constructor
        public ammo()
        {
            Energy = 100;
            Rockets = 10;
            Power = 100;
            Stamina = 100;

        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
