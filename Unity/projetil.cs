using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{
    Rigidbody rb;
    public float velocidade = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(transform.forward * velocidade * Time.deltaTime);
        Destroy(gameObject, 1);
    }
}
