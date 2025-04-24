using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    PlayerSpells playerSpells;
    PlayerMovement playerMovement;
    bool inHitReach = false;
    void Start()
    {
        playerSpells = GetComponent<PlayerSpells>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        // Do the code that does the code
        HandleMovement();
        HandleSpells();
    }
    void HandleMovement()
    {
        // Get the wasd input and send use it in AddMoveInput
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");
        playerMovement.AddMoveInput(forwardInput, rightInput);
    }
    void HandleSpells()
    {
        // If a certain key is pressed, Cast a certain 'spell'
        if(Input.GetKeyDown(KeyCode.F) && inHitReach){playerSpells.TestSpell();}
        if(Input.GetKeyDown(KeyCode.Mouse0) && inHitReach){playerSpells.TestSpell();}

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            inHitReach = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            inHitReach = false;
        }
    }
}