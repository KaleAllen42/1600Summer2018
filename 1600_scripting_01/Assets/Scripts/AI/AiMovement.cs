using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AiMovement : MonoBehaviour
{

	private NavMeshAgent Agent;
	public Transform Destination;
	
	// Use this for initialization
	void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Agent.destination = Destination.position;
	}
}
