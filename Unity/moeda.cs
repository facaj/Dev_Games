using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moeda : MonoBehaviour {
    AudioSource som;
    Renderer ren;
    SphereCollider col;
    public Text texto;
	// Use this for initialization
	void Start () {
        som = GetComponent<AudioSource>();
        ren = GetComponent<Renderer>();
        col = GetComponent<SphereCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            som.Play();
            ren.enabled = false;
            col.enabled = false;
            texto.text = "Colidio";
            Destroy(gameObject,som.clip.length);
        }
    }
}
