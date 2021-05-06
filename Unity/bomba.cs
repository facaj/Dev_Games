using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour {
	public float raio = 5f;
	public float poder = 15f;
	Collider[] colliders;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		colliders = Physics.OverlapSphere(transform.position,raio);
		foreach (Collider item in colliders)
		{
			rb = item.GetComponent<Rigidbody>();
			if(rb != null){
				rb.AddExplosionForce(poder,transform.position,raio,5f,ForceMode.Impulse);
			}
		}
	}
	
	void  OnDrawGizmos() {
		Gizmos.color = new Color(0,1,0,0.5f);
		Gizmos.DrawSphere(transform.position,raio);
	}
}
