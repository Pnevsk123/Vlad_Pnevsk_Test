using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float Speed;
    private Rigidbody rb;

     void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

     void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        rb.AddForce(direction * Speed);
    }


}


