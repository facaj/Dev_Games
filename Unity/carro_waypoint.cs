using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class carro_waypoint : MonoBehaviour
{
  
    public Transform[] waypoints;
    NavMeshAgent agent;   
    int indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.enabled = false;
        agent.enabled = true;
        agent.SetDestination(waypoints[indice].transform.position);
        
    }

    
    // Update is called once per frame
    void Update()
    {
        //Ray ray = new Ray(transform.position, transform.forward *0.3f);
         RaycastHit hit;
         if(Physics.Raycast(transform.position,transform.forward, out hit,10)){
             if(hit.transform.tag == "car")
             {
                 agent.isStopped = true; ;
             }
             
         }
         else { agent.isStopped = false; }
         Debug.DrawRay(transform.position, transform.forward * 3);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.tag == "waypoint" &&  other.name == waypoints[indice].name)
        {
            if(indice == waypoints.Length -1)
            {
                indice = 0;
            }
            else { indice = indice + 1; }
            agent.SetDestination(waypoints[indice].transform.position);
            //print(name + " " + indice);
           
            
        }
    }
}
