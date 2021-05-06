using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime * 5,0,0);
        transform.Translate( 0, 0, Input.GetAxis("Vertical") * Time.deltaTime * 5);
    }
}
