using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
  public Transform[] waypoints;
  UnityEngine.AI.NavMeshAgent agent;
  int indice = 0;
  
    void Start()
    {
          agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            agent.SetDestination(waypoints[indice].transform.position);
    }

    void Update()
    {
      RaycastHit hit;
      if(Physics.Raycast(transform.position,transform.forward, out hit,10)){
          if(hit.transform.tag == "Player")
          {
              agent.SetDestination(hit.transform.position);
          }

      }

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
        }
    }
}
