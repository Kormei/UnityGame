using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    private Vector3 moveDirection;
    public float moveSpeed = 5f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Correct the move direction and keep you on the ground
    void Update()
    {      
        moveDirection.Normalize();
        moveDirection.y = -1f;

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
    // Using input determines moveDirection
    public void AddMoveInput(float forwardInput, float rightInput)
    {
        Vector3 forward = transform.forward;
        Vector3 right = transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        moveDirection = (forwardInput * forward) + (rightInput * right);
    }
}