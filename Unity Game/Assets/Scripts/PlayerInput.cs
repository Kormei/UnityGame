using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    PlayerSpells playerSpells;
    PlayerMovement playerMovement;
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
        if(Input.GetKeyDown(KeyCode.F)){playerSpells.TestSpell();}
        if(Input.GetKeyDown(KeyCode.Mouse0)){playerSpells.TestSpell();}

    }
}