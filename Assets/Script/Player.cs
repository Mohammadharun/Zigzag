using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    private bool direction;

    //private bool direction;
    private Vector3 velocity = Vector3.zero;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            direction = !direction;
            if (direction)
                velocity = Vector3.forward * speed;
            else
                velocity = Vector3.right * speed;
        }

        rb.MovePosition(transform.position + velocity * Time.deltaTime);
    }
}
