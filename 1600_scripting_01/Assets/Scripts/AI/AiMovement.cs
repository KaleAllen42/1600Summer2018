using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AiMovement : MonoBehaviour
{

	private NavMeshAgent Agent;
	public Transform Destination;
	public AIControl Control;
	
	// Use this for initialization
	void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
		Control.ConfigAI(Agent);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Agent.destination = Destination.position;
	}
}
