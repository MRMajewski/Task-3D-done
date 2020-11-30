using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody rigidbody;

    void Update()
    {
        UpdateMovement();

    }

    private void UpdateMovement()
    {
        var direction = Vector3.zero; 

        if (Input.GetKey(KeyCode.UpArrow))
            direction += Vector3.forward;

        if (Input.GetKey(KeyCode.DownArrow))
            direction += Vector3.back;

        if (Input.GetKey(KeyCode.LeftArrow))
            direction += Vector3.left;

        if (Input.GetKey(KeyCode.RightArrow))
            direction += Vector3.right;

        rigidbody.AddTorque(direction * speed);
    }
}

