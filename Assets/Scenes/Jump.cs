using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rb;
    Groundable groundable;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundable = GetComponent<Groundable>();
    }

    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && groundable.IsGrounded())
        {
            Vector3 jumpVector = Vector3.up * jumpForce;
            rb.AddForce(jumpVector, ForceMode.VelocityChange);
        }
    }
}
