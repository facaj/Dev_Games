using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class player : MonoBehaviour {
    NavMeshAgent agent;
    Vector3 local;
    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();       
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit aqui;
            if (Physics.Raycast(ray, out aqui, 100))
            {
                agent.SetDestination(aqui.point);
            }
        }
    }
}
