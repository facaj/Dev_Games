using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrulha : MonoBehaviour
{
    public Transform[] waypoints;
    NavMeshAgent agent;
    public int indice = 0;
    Animator anim;
    public bool perserguir = false;
    public Transform alvo;
    // Start is called before the first frame update

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    public  void iniciaPatrulha()
    {
        
        agent.SetDestination(waypoints[indice].transform.position);
       
    }

    private void OnTriggerEnter(Collider other)
    {
       // print("entrou");
        if (other.transform.tag == "waypoint" && other.name == waypoints[indice].name)
        {
            if (indice == waypoints.Length - 1)
            {
                indice = 0;
            }
            else { indice = indice + 1; }
            agent.SetDestination(waypoints[indice].transform.position);
            //print(name + " " + indice);


        }
    }

    // Update is called once per frame
    public void paraPatrulha()
    {
        agent.SetDestination(transform.position);
    }
    public void Update()
    {
        if (perserguir)
        {
            agent.SetDestination(alvo.position);
        }
        if (Mathf.Abs(agent.desiredVelocity.x + agent.desiredVelocity.z) > 0)
        {
            anim.SetBool("correr", true);
        }
        else
        {
            anim.SetBool("correr", false);
        }
    }

    public void perseguir()
    {
        if (perserguir)
        {
            perserguir = false;
        }
        else { perserguir = true; }
        //print(perserguir);
    }

    public void cacar()
    {
        agent.SetDestination(alvo.position);
    }
}
