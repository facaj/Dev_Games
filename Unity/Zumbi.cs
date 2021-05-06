using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour
{
    Patrulha patrulha;
    Animator anim;
    CampoDeVisao visao;
    // Start is called before the first frame update
    void Start()
    {
        patrulha = GetComponent<Patrulha>();
        visao = GetComponent<CampoDeVisao>();
        patrulha.iniciaPatrulha();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (visao.encontrouAlvo)
        {
            print("achou");
            patrulha.cacar();
        }

    }
}
