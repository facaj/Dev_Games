using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float sensibilidade = 100f;
    public Transform corpo;
    public Canvas interagir;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    float xRotation = 0f;
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;
      

        corpo.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * 5);
        corpo.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 5, 0, 0);
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        corpo.Rotate(0, mouseX, 0);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward,out hit, 1))
        {
            if(hit.transform.tag == "personagem")
            {
                interagir.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.transform.SendMessage("deveSeguir");
                }
            }

        }
        else { interagir.enabled = false; }
        Debug.DrawRay(transform.position, transform.forward * 1);
    }
}
