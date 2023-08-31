using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float moveSpeed;
    public float rotationSpeed;

    Vector3 turn;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        HendleDirectionalMovement();
    }

    void LateUpdate()
    {
        HandleMouseRotation();
    }

    private void HendleDirectionalMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        movementDirection.Normalize();
        Vector3 jumpDirection = Vector3.up * rb.velocity.y;

        rb.velocity = (movementDirection * moveSpeed) + jumpDirection;
    }

    private void HandleMouseRotation()
    {
        turn.x += Input.GetAxis("Mouse X");
        float rotationY = turn.x * rotationSpeed;
        transform.localRotation = Quaternion.Euler(0, rotationY, 0);
    }
}
