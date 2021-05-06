using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class personagem : MonoBehaviour
{
    NavMeshAgent agente;
    bool seguir = false;
    public Transform destino;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (seguir)
        {
            agente.SetDestination(destino.position);
        }
        if(Mathf.Abs(agente.desiredVelocity.x + agente.desiredVelocity.z) > 0)
        {
            anim.SetBool("andar", true);
        }
        else
        {
            anim.SetBool("andar", false);
        }
    }

    public void deveSeguir()
    {
        if (seguir)
        {
            seguir = false;
           
        }
        else { seguir = true; }
        print(seguir);
    }
}
