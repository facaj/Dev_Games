using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moto : MonoBehaviour {
    Animation anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("d"))
        {
            anim.Play("DIREITA");
        }
        if (Input.GetKeyDown("a"))
        {
            anim.Play("ESQUERDA");
        }
    }
}
