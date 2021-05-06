using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float velocidade;
    public GameObject bala;
    public Transform arma;
    public ParticleSystem particulas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidade * Time.deltaTime, Input.GetAxis("Vertical") * velocidade * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            particulas.Play(false);
        }
            if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala, arma.position,arma.rotation);
        }
    }

 
}
