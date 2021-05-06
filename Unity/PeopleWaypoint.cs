using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PeopleWaypoint : MonoBehaviour
{
    NavMeshAgent agent;
    Transform destino;
    CampoDeVisao visao;
    public Transform[] waypoints;
    int way;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        visao = GetComponent<CampoDeVisao>();
        way = Random.Range(0, waypoints.Length);
        agent.SetDestination(waypoints[way].transform.position);
    }

 
    // Update is called once per frame
    void Update()
    {



        if (visao.encontrouAlvo)
        {
            destino = visao.ultimaVisualizacao;
            agent.SetDestination(destino.position);           
            way = Random.Range(0, waypoints.Length);
        }
        /**else
        {
            agent.SetDestination(waypoints[way].transform.position);
        }*/

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "waypoint" && other.name == waypoints[way].name)
        {
            way = Random.Range(0, waypoints.Length);
            agent.SetDestination(waypoints[way].transform.position);
            
        }
    }
}
