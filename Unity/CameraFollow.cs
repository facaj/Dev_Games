using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo;
    public float smoothSpeed = 0.2f;
    public Vector3 distancia;

    private void LateUpdate()
    {
        Vector3 desiredPosition = alvo.position + distancia;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(alvo);
    }
}
