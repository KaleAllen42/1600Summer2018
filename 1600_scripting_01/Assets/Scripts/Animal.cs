using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

    public float Speed;
    public int PowerLevel;
    public string PlayerName;

	// Use this for initialization
	void Start () {
        //transform.Rotate(0,45,0);
        print(PlayerName);
        print(PowerLevel);
    }
	
	// Update is called once per frame
	void Update () {
       transform.Translate(Speed,0,0);
       transform.Rotate(Speed, Speed, Speed);
    }
}
