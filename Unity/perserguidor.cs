using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class perserguidor : MonoBehaviour {
    public Transform alvo;
    NavMeshAgent cachorrinho;
	// Use this for initialization
	void Start () {
        cachorrinho = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        cachorrinho.SetDestination(alvo.position);
	}
}
