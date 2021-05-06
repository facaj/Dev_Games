using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class fuga : MonoBehaviour
{
    public Transform player;
    NavMeshAgent agent;
    public float distanciaMinima;
    public GameObject visualizar;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, player.transform.position);
        print(distancia);
        if(distancia < distanciaMinima)
        {
            Vector3 dirToPlayer = transform.position - player.transform.position;
            
            Vector3 newPos = transform.position + dirToPlayer;
            visualizar.transform.position = newPos;
            agent.SetDestination(newPos);
        }
    }
}
