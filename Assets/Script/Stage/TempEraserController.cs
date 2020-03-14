using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempEraserController : MonoBehaviour
{
    Rigidbody eraser_rb;
    public float torque;
    
    void Start()
    {
        eraser_rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        eraser_rb.AddTorque(new Vector3(torque, 0, 0));
    }
}
