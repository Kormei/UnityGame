using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    private Vector3 moveDirection;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {      
        moveDirection.Normalize();
        moveDirection.y = -1f;

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
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