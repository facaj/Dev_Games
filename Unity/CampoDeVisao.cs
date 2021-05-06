using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampoDeVisao : MonoBehaviour
{
    public Transform alvo;
    public Transform ultimaVisualizacao;
    public float maxAngle;
    public float maxRadius;
    public bool encontrouAlvo;


    public void OnDrawGizmos()
    {

        Gizmos.DrawWireSphere(transform.position, maxRadius);
        Vector3 linha1 = Quaternion.AngleAxis(maxAngle, transform.up) * transform.forward * maxRadius;
        Vector3 linha2 = Quaternion.AngleAxis(-maxAngle, transform.up) * transform.forward * maxRadius;

        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, linha1);
        Gizmos.DrawRay(transform.position, linha2);

    }


    bool segue()
    {
        Collider[] alvosVistos = Physics.OverlapSphere(transform.position, maxRadius);
        
        for(int i=0;i< alvosVistos.Length ;i++)
        {
            Vector3 distanciaEntreObjetos = (alvo.position - transform.position).normalized;
            float angulo = Vector3.Angle(transform.forward, distanciaEntreObjetos);
            if (angulo < maxAngle)
            {
                print("achei vc");
                Ray ray = new Ray(transform.position, alvo.position - transform.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, maxRadius))
                {
                    print(hit.transform.name);
                    if(hit.transform.tag == "Player"){
                        ultimaVisualizacao = alvo;
                        return true;
                    }
                }
            }
        }
        return false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
