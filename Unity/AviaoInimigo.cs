using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoInimigo : MonoBehaviour
{
    public Transform[] alvo;
    public int indice = 0;
    public float velocidadeRotacaoPadrao = 0.5f;
    float velocidadeRotacao;
    public float velocidadePadrao = 20;
    float velocidade ;
    public float distanciaDaVisao = 80;
    public GameObject projetil;

    public enum Estados { Patrulha, Ataca, Foge};
    public Estados estado;

    // Start is called before the first frame update
    void Start()
    {
        velocidadeRotacao = velocidadeRotacaoPadrao;
        velocidade = velocidadePadrao;
    }


    // Update is called once per frame
    void Update()
    {
        if (estado == Estados.Patrulha)
        {
            SeguirAlvo(alvo[indice]);
        }
        if (estado == Estados.Foge)
        {
            SeguirAlvo(alvo[indice]);
        }

        Debug.DrawRay(transform.position, transform.forward * distanciaDaVisao);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, distanciaDaVisao))
        {

            if (hit.transform.tag == "Player")
            {
                SeguirAlvo(hit.transform);
                estado = Estados.Ataca;
                Instantiate(projetil, transform.position, Quaternion.identity);
                print("Mete bala");
            }
        }
    }

    void SeguirAlvo(Transform alvo)
    {
        // Rotação
        Vector3 pos = alvo.position - transform.position;
        Quaternion rotacao = Quaternion.LookRotation(pos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotacao, Time.deltaTime);

       
        if(Vector3.Distance(alvo.position,transform.position) < 5)
        {
            velocidadeRotacao += 0.1f;
            velocidade -= 5;
        }
        else { velocidadeRotacao = velocidadeRotacaoPadrao; velocidade = velocidadePadrao; }


        //Movimento
        transform.position += transform.forward * Time.deltaTime * velocidade;
    }

    private void OnTriggerEnter(Collider other)
    {       
        if (other.transform.tag == "waypoint" && other.name == alvo[indice].name)
        {            
            if (indice >= alvo.Length - 1)
            {
                indice = 0;
            }
            else { indice = indice + 1; }
        }
    }
  
}
