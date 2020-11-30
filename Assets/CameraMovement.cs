using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;


    public float smoothSpeed = 0.125f;

   
    private void Update()
    {
        
    
    Vector3 targetPosition = target.position + offset;
    Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);

    transform.position = smoothPosition;
    }

    }

